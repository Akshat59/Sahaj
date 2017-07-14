using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
                                    foreach (Control grandchild in child.Controls) { ResetControls(grandchild); }
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

            #region FormValidation

            public static void DontAllow_Empty(Control control,ErrorProvider errorProvider,CancelEventArgs e)
            {
                if(control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    if (txtbox.Text.Trim() == String.Empty)
                    {
                        errorProvider.SetError(txtbox, "Required");
                        e.Cancel = true;
                    }
                    else
                        errorProvider.SetError(txtbox, "");
                    
                }
            }

            public static bool UC_hasValidationErrors(Control.ControlCollection controls)
            {
                bool hasError = false;

                // Now we need to loop through the controls and deterime if any of them have errors
                foreach (Control control in controls)
                {
                    // check the control and see what it returns
                    bool validControl = IsValid(control);
                    // If it's not valid then set the flag and keep going.  We want to get through all
                    // the validators so they will display on the screen if errorProviders were used.
                    if (!validControl)
                    { hasError = true; }

                    // If its a container control then it may have children that need to be checked
                    if (control.HasChildren)
                    {
                        if (UC_hasValidationErrors(control.Controls))
                        { hasError = true; }
                    }
                }
                return hasError;
            }
            private static bool IsValid(object eventSource)
            {
                string name = "EventValidating";

                Type targetType = eventSource.GetType();

                do
                {
                    FieldInfo[] fields = targetType.GetFields(
                         BindingFlags.Static |
                         BindingFlags.Instance |
                         BindingFlags.NonPublic);

                    foreach (FieldInfo field in fields)
                    {
                        if (field.Name == name)
                        {
                            EventHandlerList eventHandlers = ((EventHandlerList)(eventSource.GetType().GetProperty("Events",
                                (BindingFlags.FlattenHierarchy |
                                (BindingFlags.NonPublic | BindingFlags.Instance))).GetValue(eventSource, null)));

                            Delegate d = eventHandlers[field.GetValue(eventSource)];

                            if ((!(d == null)))
                            {
                                Delegate[] subscribers = d.GetInvocationList();

                                // ok we found the validation event,  let's get the event method and call it
                                foreach (Delegate d1 in subscribers)
                                {
                                    // create the parameters
                                    object sender = eventSource;
                                    CancelEventArgs eventArgs = new CancelEventArgs();
                                    eventArgs.Cancel = false;
                                    object[] parameters = new object[2];
                                    parameters[0] = sender;
                                    parameters[1] = eventArgs;
                                    // call the method
                                    d1.DynamicInvoke(parameters);
                                    // if the validation failed we need to return that failure
                                    if (eventArgs.Cancel)
                                        return false;
                                    else
                                        return true;
                                }
                            }
                        }
                    }

                    targetType = targetType.BaseType;

                } while (targetType != null);

                return true;
            }
            #endregion

            #region GeneralFunctions
            public static int GetAge(DateTime reference, DateTime birthday)
            {
                int age = reference.Year - birthday.Year;
                if (reference < birthday.AddYears(age)) age--;

                return age;
            }



            #endregion GeneralFunctions

        }
    }
}
