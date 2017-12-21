﻿using System;
using System.Windows.Forms;
using m1.BPC;
using m1.Shared;
using m1.Shared.Entities;
using System.Threading;
using Sayen.userForms;

namespace Sayen
{
    public partial class frm_login : Form
    {        
        public frm_login()
        {
            InitializeComponent();
            lbl_loginMsg.Visible = false;
            btn_login.Focus();
            this._genBPC = null;
            AppGlobal.g_GEntity = new GenEntity();
        }

        #region Objects
        private genBPC _genBPC;

        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }
            
        }

        //private GenEntity _gEntity;

        //public GenEntity GEntity
        //{
          //  get { if (_gEntity == null) { _gEntity = new GenEntity(); } return _gEntity; }
        //}
        #endregion

        #region Properties
        private string _appErrorLog = String.Empty;

        private string _s_uname = String.Empty;

        public string S_uname
        {
            get { return _s_uname; }
            set { _s_uname = value; }
        }
        private string _s_pwd = String.Empty;

        public string S_pwd
        {
            get { return _s_pwd; }
            set { _s_pwd = value; }
        }

      
        #endregion

        #region Controls

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            lbl_loginMsg.Visible = false;
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {
            lbl_loginMsg.Visible = false;
        }

        private void lbl_loginIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(UserMessages.LoginIsuuesMsg, UserMessages.LoginIsuuesTitle);
        }

        private void lbl_title_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                var objFrmBackdoor = new frm_Backdoor(this);
                objFrmBackdoor.Show();
            }
            catch (Exception Ex)
            {
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
                setLables(AppConstants.CallStatusError, UserMessages.AppException);
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            m_btnlogin_click();

        }
        #endregion     Controls  

        #region UserMethods
        private void m_btnlogin_click()
        {
            try
            {
                string S_uname = txt_uname.Text;
                string S_pwd = txt_pwd.Text;


                if (S_uname.Equals(String.Empty) || S_pwd.Length < 6)
                {
                    setLables(AppConstants.CallStatusError, UserMessages.InvalidLogon);
                }
                else
                {
                    AppGlobal.g_GEntity.UserEntity.Input_user_id = S_uname.Trim();
                    AppGlobal.g_GEntity.UserEntity.User_pwd = S_pwd;

                    if (_genBPC == null) { _genBPC = new genBPC(); }

                    if (!_genBPC.bpcTestDatabaseConnection(AppGlobal.g_GEntity))
                    {
                        setLables(AppConstants.CallStatusError, UserMessages.DatabaseNotConnected);
                    }
                    else
                    {
                        if (_genBPC.bpcValidateUserLogin(AppGlobal.g_GEntity))
                        {
                            //frm_login frmlgn = new frm_login();
                            //Thread newThread = new Thread(frmlgn.thread1);
                            //newThread.Start("");
                            setLables(AppConstants.CallStatusError, UserMessages.ValidLogon);

                            Thread.Sleep(500);

                            DialogResult res = MessageBox.Show(UserMessages.LogonDisclaimer, UserMessages.LogonDisclaimerTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            //DialogResult res = DialogResult.Yes;

                            if (res == DialogResult.Yes)
                            {

                                this.Hide();
                                frm_Home objFrmHome = new frm_Home();
                                objFrmHome.Show();
                                objFrmHome.Closed += (s, args) => this.Close();
                                objFrmHome.Show();
                            }
                            else
                            {
                                Application.Exit();
                            }

                        }
                        else
                        {
                            setLables(AppConstants.CallStatusError, UserMessages.InvalidLogon);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                ErrorLogEntity elog = new ErrorLogEntity();
                elog.HelpLink = Ex.HelpLink;
                //elog.InnerException = Ex.InnerException.ToString();
                elog.U_error_message = Ex.Message;
                elog.U_error_source = Ex.Source;
                elog.U_stacktrace = Ex.StackTrace;
                elog.TargetSite = Ex.TargetSite;
                elog.U_IfLogtoDatabase = true;
                elog.U_IfLogtoEventLogs = true;
                elog.U_error_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); ;
                elog.U_error_loggedby = ErrorLogEntity.errorLoggedBy.System;
                ExceptionManagement.logAppException(elog);
                setLables(AppConstants.CallStatusError, UserMessages.AppException);
            }
        }


        public void setLables(string status,string Message)
        {
            if (status == AppConstants.CallStatusError)
            {
                lbl_loginMsg.Visible = true;
                lbl_loginMsg.ForeColor = System.Drawing.Color.Maroon;
                lbl_loginMsg.Text = Message;
            }
            else if (status == AppConstants.CallStatusSuccess)
            {
                lbl_loginMsg.Visible = true;
                lbl_loginMsg.ForeColor = System.Drawing.Color.Black;
                lbl_loginMsg.Text = Message;
            }
            else
            {
                lbl_loginMsg.Visible = false;
                lbl_loginMsg.ForeColor = System.Drawing.Color.Black;
                lbl_loginMsg.Text = "";
            }

        }

        #endregion UserMethods


    }


}
