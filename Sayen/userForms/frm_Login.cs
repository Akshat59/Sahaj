using System;
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
            this._genBPC = null;
            
        }

        #region Objects
        private genBPC _genBPC;

        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }
            
        }

        private GenEntity _gEntity;

        public GenEntity GEntity
        {
            get { if (_gEntity == null) { _gEntity = new GenEntity(); } return _gEntity; }
        }
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

        private void lbl_title_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                var objFrmBackdoor = new frm_Backdoor(this);
                objFrmBackdoor.Show();
            }
            catch (Exception Ex)
            {
                _appErrorLog = ExceptionManagement.logAppException(Ex);
                setLables(AppConstants.CallStatusError, UserMessages.AppException);
            }
            finally
            {
                AppGlobal.appErrorLog = _appErrorLog;
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            m_btnlogin_click();

        }
        #endregion       

        #region PrivateMethods
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
                    GEntity.UserEntity.Input_user_id = S_uname;
                    GEntity.UserEntity.User_pwd = S_pwd;

                    if (_genBPC == null) { _genBPC = new genBPC(); }

                    if (!_genBPC.bpcTestDatabaseConnection(GEntity))
                    {
                        setLables(AppConstants.CallStatusError, UserMessages.DatabaseNotConnected);
                    }
                    else
                    {
                        if (_genBPC.bpcValidateUserLogin(GEntity))
                        {
                            //frm_login frmlgn = new frm_login();
                            //Thread newThread = new Thread(frmlgn.thread1);
                            //newThread.Start("");
                            setLables(AppConstants.CallStatusError, UserMessages.ValidLogon);

                            Thread.Sleep(500);

                            //DialogResult res = MessageBox.Show(UserMessages.LogonDisclaimer, UserMessages.LogonDisclaimerTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            DialogResult res = DialogResult.Yes;

                            if (res == DialogResult.Yes)
                            {

                                this.Hide();
                                var objFrmHome = new frm_Home();
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
                _appErrorLog = ExceptionManagement.logAppException(Ex);
                setLables(AppConstants.CallStatusError, UserMessages.AppException);
            }
            finally
            {
                AppGlobal.appErrorLog = _appErrorLog;
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

        public void thread1(object data)
        {
            
            //frm_login frmlgn = new frm_login();
            lbl_loginMsg.Visible = true;
            lbl_loginMsg.Text = "";
        }
        
        #endregion
       
    }

    
}
