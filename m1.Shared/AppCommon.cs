using m1.Shared;
using m1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static m1.Shared.AppConstants;

namespace m1.Shared
{
    public class AppCommon
    {
    }

    #region Utilities
    public class Utilities
    {
        #region Declaration        
        public class u_keys
        {
          public const string fileDialogImg = "Image files|*.jpg;*.jpeg;*.png";
          public const string fileDialogAll= "All files (*.*)|*.*";
        }
        /// <summary>
        /// This enum have codes which signifies type of operation done on Document upload panel
        /// U- Upload, V- View, D- Delete
        /// </summary>

        public enum DocAction { U=0, V=1, D=2,H=3 }

        #endregion Declaration


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

        public static void DontAllow_Empty(Control control, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (control is TextBox)
            {
                TextBox txtbox = (TextBox)control;
                if (txtbox.Text.Trim() == String.Empty)
                {
                    errorProvider.SetError(txtbox, "Required");
                    e.Cancel = true;
                }
                else { errorProvider.SetError(txtbox, ""); }
            }
        }

        public static void DontAllow_InvalidDOB(Control control, Control errControl, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (control is DateTimePicker)
            {
                DateTimePicker dtp = (DateTimePicker)control;

                DateTime dt1 = DateTime.Now.Date;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(dtp.Text,"dd-MM-yyyy",CultureInfo.InvariantCulture));

                if (dt2 >= dt1)
                {
                    errorProvider.SetError(errControl, "Should be of Past");
                    e.Cancel = true;
                }                
                else { errorProvider.SetError(errControl, ""); }
            }
        }

        public static void DontAllow_InvalidExpiryDate(Control control, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (control is DateTimePicker)
            {
                DateTimePicker dtp = (DateTimePicker)control;

                DateTime dt1 = DateTime.Now.Date;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(dtp.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                if (dt2 <= dt1)
                {
                    errorProvider.SetError(dtp, "Should be future Date");
                    e.Cancel = true;
                }
                else { errorProvider.SetError(control, ""); }
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

        #region GetAlertTextBox

        public static TextBox GetAlertTextBox()
        {
            TextBox txt_ucAlerts = new TextBox()
            {
                Name = "txt_ucAlerts",
                Text = string.Empty,
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.AliceBlue,
                ForeColor = Color.RoyalBlue,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Center,
                AutoSize = false,
                ReadOnly = true,
                ShortcutsEnabled = false,
            };

            return txt_ucAlerts;
        }


        #endregion

        #region SelectFiles
        public static string SelectImagePath(out string fileName)
        {
            fileName = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            // Filter - file types, that will be allowed to upload
            dialog.Filter = u_keys.fileDialogImg;
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {                
                FileInfo fi = new FileInfo(dialog.FileName);
                fileName = fi.Name; //returns only file name
                return dialog.FileName; //It returns whole path
            }
            else
            {
                return string.Empty;
            }

            
        }
        #endregion GetFileDialog

        #region SetDocPanel
       
        public static void SetDocPanel(e_DocType docType, LinkLabel lbl_upload, LinkLabel lbl_view, PictureBox pb_del, Label lbl_filename, PictureBox pb_viewDoc,Panel panel_viewDoc, DocAction mode, DocumentCollection docColl)
        {
            string _fileName = string.Empty;

            //Perform action as per control clicked on Image Panel
            switch (mode)
            {
                //Upload
                case DocAction.U:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    RemoveDoc(docType, docColl);
                    if (AddDoc(docType, out _fileName, docColl))
                    {
                        lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = true;
                        lbl_filename.Text = _fileName;
                    }
                    else { lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = false; }
                    if(_fileName.Length>0)
                    { lbl_filename.Text = _fileName;}
                    break;
                //View
                case DocAction.V:
                    if (ViewDoc(docType, pb_viewDoc, docColl))
                    { panel_viewDoc.Visible = true; }
                    else { panel_viewDoc.Visible = false; }
                    break;
                //Delete
                case DocAction.D:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    RemoveDoc(docType, docColl);
                    lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = false;
                    break;
                //Hide
                case DocAction.H:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    break;
            }
        }
        

        private static bool AddDoc(e_DocType e_DocType, out string filename, DocumentCollection docCol)
        {         
            formDocs edoc = new formDocs();
            //edoc.DocPath = "C:\\Users\\punee\\Desktop\\akshat\\img_usr_a01659_ppic.png";
            edoc.DocPath = Utilities.SelectImagePath(out filename);
            if (edoc.DocPath != string.Empty)
            {
                RemoveDoc(e_DocType,docCol);
                edoc.DocType = e_DocType;
                docCol.Add(edoc);
                return true;
            }
            else { return false; }

        }
        private static void RemoveDoc(e_DocType e_DocType, DocumentCollection docCol)
        {            
            foreach (formDocs item in docCol)
            {
                if (item.DocType.Equals(e_DocType))
                {
                    docCol.Remove(item);
                    break;
                }
            }

        }       

        private static bool ViewDoc(e_DocType e_DocType, PictureBox pb_viewDoc, DocumentCollection docCol)
        {
            pb_viewDoc.Image = null;
            foreach (formDocs item in docCol)
            {
                if (item.DocType.Equals(e_DocType))
                {
                    if (File.Exists(item.DocPath))
                    {
                        pb_viewDoc.Image = Image.FromFile(item.DocPath);
                    }
                    return true;
                }
                //else { return false; }
            }            

            if (pb_viewDoc.Image == null)
            { return false; }

            return false;

        }

        private static void HideDoc(PictureBox pb_viewDoc,Panel panel_viewDoc)
        {
            pb_viewDoc.Image = null;
            panel_viewDoc.Visible = false;
        }

        #endregion SetDocPanel

    }
    #endregion Utilities


    #region Custom Attributes
    /// <summary>
    /// Custom Attribute define sif text can be camel case or not.
    /// </summary>

    //[System.AttributeUsage(System.AttributeTargets.Property)]
    public class IsCamelCase : Attribute
    {
        public readonly bool isCamelCase;

        public IsCamelCase(bool iscamelcase)
        {
            this.isCamelCase = iscamelcase;
        }
    }

    #endregion Custom Attributes

    #region AppDBContants
    public class AppDBContants
    {
        public const string EmpDetails = "d1_cdt_employees";
        public const string EmpDetailsPkey = "emp_id";
        public const string EmpDetailsPkeyLen = "7";
    }
    #endregion
}
