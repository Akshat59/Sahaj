using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.BPC;
using m1.Shared;
using m1.Shared.Entities;
using System.Globalization;

namespace Sayen.UserControls
{
    public partial class uc_welcome : UserControl
    {
        #region Initiation

        
        static DateTime noteDate = DateTime.Now;
        static string dt = String.Format("{0:d MMM}", noteDate);
        string noteTitle = "Notes- " + dt + " \r\n";
        bool formLoadCall = true;
        private genBPC _genBPC;
        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }

        public uc_welcome()
        {
            InitializeComponent();
        }        

        private void uc_welcome_Load(object sender, EventArgs e)
        {
            initializeDisplay();

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;


            timer1.Enabled = true;
            timer1.Interval = 1000;
            lbl_currentTime.Text = string.Empty;
            lbl_currentTime.Visible = true;
            LoadNotes();
        }

        private void initializeDisplay()
        {
            if (AppGlobal.g_GEntity.UserEntity != null)
            {
                string _userFullName = AppGlobal.g_GEntity.UserEntity.User_fname + " " + AppGlobal.g_GEntity.UserEntity.User_lname;
                if (_userFullName.Length > 0) { lbl_u_fullname.Text = _userFullName; lbl_u_fullname.Visible = true; }
                else { lbl_u_fullname.Text = ""; lbl_u_fullname.Visible = false; }
            }
        }

        #endregion Initiation

        #region Controls
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentTime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            noteTitle = "Notes-";
            noteDate = e.Start;
            formLoadCall = false;
            string dt = String.Format("{0:d MMM}", noteDate);
            noteTitle = noteTitle + " " + dt + " \r\n";
            richTextBox1.Text = noteTitle;
            LoadNotes();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            bool DontAllowKey = false;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.PageDown
                || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.End || e.KeyCode == Keys.Home || (e.KeyCode == Keys.A && e.Modifiers == Keys.Control))
            { DontAllowKey = false; }

            else
            {
                if (richTextBox1.SelectionStart <= noteTitle.Replace(System.Environment.NewLine, "").Trim().Length)
                {
                    DontAllowKey = true;
                }

                if (richTextBox1.SelectionStart >= noteTitle.Replace(System.Environment.NewLine, "").Trim().Length
                    && (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter))
                {
                    DontAllowKey = false;
                }
            }

            e.SuppressKeyPress = DontAllowKey;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            SaveNotes();
        }
        #endregion Controls

        #region UserMethods
        
        private void SaveNotes()
        {
            richTextBox1.Visible = false;
            UserEntity userEntity = new UserEntity();
            userEntity.User_id = AppGlobal.g_GEntity.UserEntity.User_id;
            userEntity.UserNoteDate = noteDate;

            string note = richTextBox1.Text.Trim();

            int q = noteTitle.Trim().Replace(System.Environment.NewLine, "").Length;
            note = note.Substring(noteTitle.Trim().Replace(System.Environment.NewLine, "").Length, note.Length - noteTitle.Trim().Replace(System.Environment.NewLine, "").Length).Trim();

            userEntity.UserNoteText = note;
            GenBPC.bpcSaveUserNotes(userEntity);
        }

        private void LoadNotes()
        {

            if (AppGlobal.g_GEntity.UserEntity != null)
            {
                UserEntity userEntity = new UserEntity();
                userEntity.User_id = AppGlobal.g_GEntity.UserEntity.User_id;
                userEntity.UserNoteDate = noteDate;
                GenBPC.bpcGetUserNotes(userEntity);

                if (userEntity.UserNoteText != string.Empty)
                {
                    richTextBox1.Text = noteTitle + "\r\n" + userEntity.UserNoteText.ToString();                    
                }
                else
                {
                    richTextBox1.Text = noteTitle + "\r\n";
                }
                FormatNotes();

                if (formLoadCall && userEntity.UserNoteText == string.Empty)
                {
                    richTextBox1.Visible = false;
                }
                else
                {
                    richTextBox1.Visible = true;
                }
            }

        }

        private void FormatNotes()
        {
            string note = richTextBox1.Text.Trim();
            note = note.Substring(noteTitle.Replace(System.Environment.NewLine, "").Trim().Length, note.Length - noteTitle.Replace(System.Environment.NewLine, "").Trim().Length).Trim();
            
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = noteTitle.Replace(System.Environment.NewLine, "").Length;
            richTextBox1.SelectionFont = new Font("Comic Sans MS", 12,FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Teal;            
            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionStart = noteTitle.Replace(System.Environment.NewLine, "").Trim().Length;
            richTextBox1.SelectionLength = richTextBox1.Text.Length - noteTitle.Replace(System.Environment.NewLine, "").Trim().Length; 
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectionLength = 0;
        }

        #endregion UserMethods


    }
}
