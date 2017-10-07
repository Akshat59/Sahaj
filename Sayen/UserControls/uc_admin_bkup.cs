using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.BPC;
using m1.Shared.Entities;
using m1.Shared.Configs;
using System.Globalization;
using m1.Shared.DataBackUp;
using System.IO;
using m1.Shared;
using System.Collections;
using Sayen;

namespace Sahaj.UserControls
{
    public partial class uc_admin_bkup : UserControl
    {
        frm_Home _obj_frmHome;
        string bkup_path;
        public uc_admin_bkup(frm_Home obj_frmHome)
        {
            InitializeComponent();
            _obj_frmHome = obj_frmHome;
            string _systemDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
            bkup_path = ConfigSettings.GetAppSetting("BackupPath");
            bkup_path = string.Format("{0}{1}", _systemDocuments, bkup_path);

            txt_filePath.Text = bkup_path.Substring(0,bkup_path.LastIndexOf("\\"));
            string _s = ConfigSettings.GetAppSetting("AppConstants_BackupTablesList");
            string[] _s1; _s1 = _s.Split(','); clb_dataTables.DataSource = _s1;
        }


        private genBPC _genBPC;
        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }

        #region Controls
        private void rdb_backup_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_backup.Checked)
            {
                btn_backup.Text = "Back Up";
                txt_restoreDate.Text = "Restore Date YYYY-MM-DD";
                txt_restoreDate.ForeColor = Color.DarkGray;
                txt_restoreDate.Visible = false;
            }
            else if (rdb_restore.Checked) { btn_backup.Text = "Restore"; txt_restoreDate.Visible = true; }
        }

        private void chk_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectAll.Checked)
            {
                chk_selectAll.Text = "Select None";
                for (int i = 0; i < clb_dataTables.Items.Count; i++)
                {
                    if (!clb_dataTables.GetItemChecked(i))
                    {
                        clb_dataTables.SetItemChecked(i, true);
                    }
                }
            }
            else
            {
                chk_selectAll.Text = "Select All";
                for (int i = 0; i < clb_dataTables.Items.Count; i++)
                {
                    if (clb_dataTables.GetItemChecked(i))
                    {
                        clb_dataTables.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void rdb_restore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_restoreDate_Enter(object sender, EventArgs e)
        {
            txt_restoreDate.ForeColor = Color.Black;

            if (txt_restoreDate.Text == "Restore Date YYYY-MM-DD")
            { txt_restoreDate.Text = ""; }

        }

        private void txt_restoreDate_Leave(object sender, EventArgs e)
        {
            DateTime _result;
            if (!DateTime.TryParseExact(txt_restoreDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _result))
            {
                txt_restoreDate.Text = "Restore Date YYYY-MM-DD";
                txt_restoreDate.ForeColor = Color.DarkGray;
            }
            else if (txt_restoreDate.Text == "Restore Date YYYY-MM-DD")
            { txt_restoreDate.ForeColor = Color.DarkGray; }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_backup.Checked)
                {
                    for (int i = 0; i < clb_dataTables.Items.Count; i++)
                    {
                        if (clb_dataTables.GetItemChecked(i))
                        {
                            BackupData(clb_dataTables.Items[i].ToString());
                        }
                    }
                }
                else if (rdb_restore.Checked)
                {
                    for (int i = 0; i < clb_dataTables.Items.Count; i++)
                    {
                        if (clb_dataTables.GetItemChecked(i))
                        {
                            RestoreBackup(clb_dataTables.Items[i].ToString());
                        }
                    }
                }
                MessageBox.Show("Operation Successfull");
                _obj_frmHome.ResetAdminUserControlPanel();

            }
            catch (Exception Ex)
            {
                //Exception Exx = new Exception("Exception; Error while backing/restoring Data; Source: " + "uc_admin_bkup.btn_backup_Click");//logAppException
                ErrorLogEntity elog = new ErrorLogEntity();
                elog.HelpLink = Ex.HelpLink;
                //elog.InnerException = Ex.InnerException.ToString();
                elog.U_error_message = Ex.Message;
                elog.U_error_source = Ex.Source;
                elog.U_stacktrace = Ex.StackTrace;
                elog.TargetSite = Ex.TargetSite;
                elog.U_IfLogtoDatabase = true;
                elog.U_IfLogtoEventLogs = true;
                elog.U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp;
                elog.U_error_loggedby = ErrorLogEntity.errorLoggedBy.System;
                ExceptionManagement.logAppException(elog);
            }
        }
        #endregion


        private void BackupData(string tableName)
        {
            DataBackupEntity obj_dataBkup = new DataBackupEntity();
            obj_dataBkup.TableName = tableName;            

            string currentTimeStamp = DateTime.Now.ToString("yyyyMMdd");
            string _bkupPath = string.Format(bkup_path, tableName, currentTimeStamp);

            GenBPC.bpcReadTableData(obj_dataBkup);

            Utilities.RemoveTimezoneForDataSet(obj_dataBkup.ResultDataSet);

            if (obj_dataBkup.ResultDataSet.Tables.Count > 0)
            { obj_dataBkup.ResultDataSet.WriteXml(_bkupPath); }
            else
            {
                ErrorLogEntity elog = new ErrorLogEntity
                {
                    U_error_message = "No data was retrieved for Backup",
                    U_error_source = "uc_admin_bkup.BackupData",
                    U_IfLogtoDatabase = true,
                    U_IfLogtoEventLogs = true,
                    U_error_loggedby = ErrorLogEntity.errorLoggedBy.User,
                    U_error_type = ErrorLogEntity.errorType.Error,
                    U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp,
                };
                ExceptionManagement.logUserException(elog);
            }
            if (!File.Exists(_bkupPath))
            {MessageBox.Show(string.Format("Data file {0} could not be created", _bkupPath));}
        }

        private void RestoreBackup(string tableName)
        {
            DateTime _result;
            if (DateTime.TryParseExact(txt_restoreDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _result))
            {               
                string restoreDate = txt_restoreDate.Text;
                
                string _bkupPath = string.Format(bkup_path, tableName, restoreDate.Replace("-", ""));
                if (File.Exists(_bkupPath))
                {
                    DataBackupEntity obj_dataBkup = new DataBackupEntity();
                    obj_dataBkup.TableName = tableName;
                    obj_dataBkup.ResultDataSet.ReadXml(_bkupPath);
                    GenBPC.bpcWriteDataSetToTable(obj_dataBkup);                    
                }
                else { MessageBox.Show(string.Format("Data file {0} does not Exists", _bkupPath)); }
            }
            else
            {
                MessageBox.Show("Restore Date is not in Required Format (YYYY-MM-DD)");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
