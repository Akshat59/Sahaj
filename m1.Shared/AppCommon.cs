using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m1.Shared
{
    public class AppCommon
    {

        public static void ClearFormControls(UserControl _userCtrl)
        {
            foreach (Control control in _userCtrl.Controls)
            {
                if (control is Panel)
                {
                    control.Controls.Clear();
                    //control.Controls.Add(_userCtrl);
                }

                else if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
                else if (control is CheckedListBox)
                {
                    CheckedListBox chklist = (CheckedListBox)control;
                    for (int i = 0; i < chklist.Items.Count; i++)
                    {
                        chklist.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
