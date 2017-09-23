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

namespace Sahaj.UserControls
{
    public partial class uc_admin_bkup : UserControl
    {
        public uc_admin_bkup()
        {
            InitializeComponent();
            txt_filePath.Text = bkup_path.Substring(0,bkup_path.LastIndexOf("\\"));
        }

        string bkup_path = ConfigSettings.GetAppSetting("BackupPath");

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
            }
            catch (Exception Ex)
            {
                //Exception Exx = new Exception("Exception; Error while backing/restoring Data; Source: " + "uc_admin_bkup.btn_backup_Click");//logAppException
                ExceptionManagement.logAppException(Ex);
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

            obj_dataBkup.ResultDataSet.WriteXml(_bkupPath);

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

        
    }
}
