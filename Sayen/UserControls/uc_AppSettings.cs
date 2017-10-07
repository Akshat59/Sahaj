using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.Shared.Entities;
using m1.BPC;
using m1.Shared.Configs;
using m1.Shared;

namespace Sahaj.UserControls
{
    public partial class uc_AppSettings : UserControl
    {
        private genBPC _genBPC;
        private bool _firstTimeLoadDone = false;
        bool _propertyValue;
        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }
        public uc_AppSettings()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> d_AppUserRoles = new Dictionary<string, string>()
        {
            {  "EnableErrorDatabaseLogging","Enable Error Database Logging" },
            {  "EnableErrorEventLogging","Enable Error Event Logging" },

        };
        List<KeyValuePair<String, bool>> zz = new List<KeyValuePair<string, bool>>();
        public Dictionary<string, bool> xx = new Dictionary<string, bool>() { };


        private void uc_AppSettings_Load(object sender, EventArgs e)
        {
            
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            this.Width = this.Parent.Width;
            //panel1.AutoScroll = true;
            //panel1.Dock = DockStyle.Fill;
            //panel1.AutoSize = true;
            //dataGridView1.BackgroundColor = Color.AliceBlue;

            LoadPageControls();

            _firstTimeLoadDone = true;
            
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_appSettings1.Items.Count; i++)
            {
                var _currentKey = d_AppUserRoles.ElementAt(i).Key;
                var _currentKeyR = clb_appSettings1.Items[i].ToString();
                if (xx.Keys.Contains(_currentKeyR))
                {
                    _propertyValue = clb_appSettings1.GetItemChecked(i);
                    ConfigSettings.SetAppSetting(_currentKey, _propertyValue.ToString());
                }
            }
        }

        private void clb_appSettings1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox cc = (CheckedListBox)sender;
            if (_firstTimeLoadDone && cc !=null && cc.SelectedItem != null)
            {                
                string _currentKey = cc.SelectedItem.ToString();

                if (!xx.Keys.Contains(_currentKey))
                {
                    xx.Add(_currentKey, true);
                }               
            }
        }

        private void LoadPageControls()
        {
            //SetCheckBoxList as per AppConfig Value
            BindingSource bs = new BindingSource();
            bs.DataSource = d_AppUserRoles;
            clb_appSettings1.DataSource = bs;
            clb_appSettings1.DisplayMember = "Value";
            clb_appSettings1.ValueMember = "Key";

            clb_appSettings1.Height = d_AppUserRoles.Count * 15 + 5;
            int _heightOtherControls = ddl_propertyKeys.Height + txt_propertyValue.Height + 50;
            tableLayoutPanel1.RowStyles[1].Height = (d_AppUserRoles.Count * 30)> _heightOtherControls? d_AppUserRoles.Count * 30 : _heightOtherControls;

            var _l1 = clb_appSettings1.Location;
            _l1.Y += clb_appSettings1.Height;
            _l1.Y += 30;
            btn_save.Location = _l1;

            for (int i = 0; i < clb_appSettings1.Items.Count; i++)
            {
                var _currentKey = d_AppUserRoles.ElementAt(i).Key;
                var _p = ConfigSettings.GetAppSetting(_currentKey);
                if (bool.TryParse(_p, out _propertyValue))
                {
                    if (clb_appSettings1.GetItemChecked(i) != _propertyValue)
                    {
                        clb_appSettings1.SetItemChecked(i, _propertyValue);
                    }
                }
                else
                {
                    ErrorLogEntity elog = new ErrorLogEntity
                    {
                        U_error_message = string.Format("Value for {0} in config file is not valid boolean", _currentKey),
                        U_error_source = "uc_AppSettings.uc_AppSettings_Load",
                        U_IfLogtoDatabase = true,
                        U_IfLogtoEventLogs = true,
                        U_error_loggedby = ErrorLogEntity.errorLoggedBy.User,
                        U_error_type = ErrorLogEntity.errorType.Error,
                        U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp,
                    };
                    ExceptionManagement.logUserException(elog);
                }
            }


            ////SetDropDownList as per AppConfig Values

            List<string> propertyValues = new List<string>();
            
            propertyValues = (ConfigSettings.GetAllProperties());
            //propertyValues = propertyValues.Where(key => !key.StartsWith("Query"));
            propertyValues.Insert(0, AppConstants.DropDownListFirstItem);
            
            ddl_propertyKeys.DataSource = propertyValues.ToArray();

        }

        private void ddl_propertyKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddl_propertyKeys.SelectedIndex == 0) { btn_update.Enabled = false; }
            else { txt_propertyValue.Text = ConfigSettings.GetAppSetting(ddl_propertyKeys.SelectedValue.ToString()); btn_update.Enabled = true; }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ConfigSettings.SetAppSetting(ddl_propertyKeys.SelectedValue.ToString(), txt_propertyValue.Text);
        }
    }
}
