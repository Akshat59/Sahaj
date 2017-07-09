using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m1.Shared
{
    public class AppCommon
    {

        public class Utilities
        {
            #region ResetControls
            public static void CallResetControl(Control ParentControl)
            {
                if (ParentControl.HasChildren)
                { 
                    foreach (Control control in ParentControl.Controls)
                    {
                        if (control.HasChildren)
                        {
                            foreach (Control child in control.Controls)
                            {
                                if (child.HasChildren)
                                {
                                    foreach (Control grandchild in child.Controls){ResetControls(grandchild);}
                                }
                                else
                                { ResetControls(child); }
                            }
                        }
                        else
                        { ResetControls(control); }
                    }
                }
                else { ResetControls(ParentControl); }
            }

            public static void ResetControls(Control control)
            {
                if (!control.HasChildren)//Proceed if Control does not have child else handle exception
                {
                    if (control is TextBox)
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
                        CheckedListBox cl = (CheckedListBox)control;
                        for (int i = 0; i < cl.Items.Count; i++)
                        {
                            cl.SetItemChecked(i, false);
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }
                    else if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                    else
                    {
                        //Implement Control clear block and log message     #futureCode
                    }
                }
                else
                {
                    //cannot clear control having childcontrols
                    //log error message    #futureCode
                    //Resolution - add child to grandchild in calling method e.g.CallResetControl
                }

            }
            #endregion ResetControls


            #region RegEx Control
            public static void DontAllowAlphabet(object sender, KeyPressEventArgs e)
            {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space))
                { e.Handled = true; }
            }
            public static void DontAllowDigit(object sender, KeyPressEventArgs e)
            {
                if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space))
                { e.Handled = true; }
            }

            public static void DontAllowCharacters(object sender, KeyPressEventArgs e)
            {
                if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space))
                { e.Handled = true; }
            }
            #endregion

        }
    }
}
