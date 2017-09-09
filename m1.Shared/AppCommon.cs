using m1.Shared;
using m1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        /// U- Upload/Add New, V- View, D- Delete,  H-Hide , P-Populate, M - Modify/UpdateDoc for existing
        /// </summary>

        public enum e_DocAction { U=0, V=1, D=2,H=3,P=4,M=5 }

        #endregion Declaration

        #region ResetEnableDisableControls
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

        public static DialogResult GetYesNoConfirmation(string title, string text)
        {
            DialogResult res = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        public static void EnableDisableControls(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                { EnableDisableControls(control.Controls, status); }
                else
                {
                    var _property = control.GetType().GetProperty("Enabled");
                    if (_property != null && !(control is Label)||(control is LinkLabel))
                    {
                        control.Enabled = status;
                    }

                }
            }
        }

        public static void SetControlReadonly(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                { SetControlReadonly(control.Controls, status); }
                else
                {

                    if (control is TextBox)
                    { TextBox txtbox = (TextBox)control; txtbox.ReadOnly = status; txtbox.Enabled = true; }
                                    
                }
            }
        }


        #endregion ResetEnableDisableControls

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
        public static void DontAllow_FutureDate(Control control,  ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (control is DateTimePicker)
            {
                DateTimePicker dtp = (DateTimePicker)control;

                DateTime dt1 = DateTime.Now.Date;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(dtp.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                if (dt2 > dt1)
                {
                    errorProvider.SetError(control, "Cannot be future date");
                    e.Cancel = true;
                }
                else { errorProvider.SetError(control, ""); }
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
       
        public static void SetDocPanel(e_DocType docType, LinkLabel lbl_upload, LinkLabel lbl_view, PictureBox pb_del, Label lbl_filename, PictureBox pb_viewDoc,Panel panel_viewDoc, e_DocAction mode, DocumentCollection docColl)
        {
            string _fileName = string.Empty;

            //Perform action as per control clicked on Image Panel
            switch (mode)
            {
                //Upload
                case e_DocAction.U:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    if (AddDoc(docType, out _fileName, docColl))
                    {
                        lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = true;
                        lbl_filename.Text = _fileName;
                    }
                    else
                    {
                        if (PopulateDoc(docType, docColl, lbl_filename))
                        { lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = true; }
                        else { lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = false; }                        
                    }
                    if(_fileName.Length>0)
                    { lbl_filename.Text = _fileName;}
                    break;
                //View
                case e_DocAction.V:
                    if (ViewDoc(docType, pb_viewDoc, docColl))
                    { panel_viewDoc.Visible = true; }
                    else { panel_viewDoc.Visible = false; }
                    break;
                //Delete
                case e_DocAction.D:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    RemoveDoc(docType, docColl);
                    lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = false;
                    break;
                //Hide
                case e_DocAction.H:
                    HideDoc(pb_viewDoc, panel_viewDoc);
                    break;
                //Populate
                case e_DocAction.P:
                    if (PopulateDoc(docType, docColl, lbl_filename))
                    { lbl_view.Visible = pb_del.Visible = lbl_filename.Visible = true; }
                    break;
            }
        }        

        private static bool AddDoc(e_DocType e_DocType, out string filename, DocumentCollection docCol)
        {         
            
            //edoc.DocPath = "C:\\Users\\punee\\Desktop\\akshat\\img_usr_a01659_ppic.png";
            string docPath = Utilities.SelectImagePath(out filename);
            if (docPath != string.Empty)
            {
                formDocs edoc = new formDocs();
                foreach (formDocs fd in docCol)
                {                    
                    if(fd.DocType == e_DocType && fd.ExistInDB)
                    {
                        fd.DocPath = docPath;
                        fd.Image = null;
                        fd.DocUpdateType = e_DocAction.M; fd.HasChange = true; fd.ActiveInd = AppKeys.Active;             
                        return true;
                    }
                }

                RemoveDoc(e_DocType, docCol);
                edoc.DocType = e_DocType;
                edoc.DocUpdateType = e_DocAction.U; edoc.HasChange = true; edoc.ActiveInd = AppKeys.Active;

                //RemoveDoc(e_DocType,docCol);
                //edoc.DocType = e_DocType;

                //if (edoc.DocUpdateType != e_DocAction.M && !edoc.ExistInDB)
                //{ edoc.DocUpdateType = e_DocAction.U; edoc.HasChange = true; edoc.ActiveInd = AppKeys.Active; }
                //else if (edoc.DocUpdateType != e_DocAction.U && edoc.ExistInDB)
                //{ edoc.DocUpdateType = e_DocAction.M; edoc.HasChange = true; edoc.ActiveInd = AppKeys.Active; }
                //else { return false;/*Only 2 above possible way alowed for doc to get added; Log into applog #futureCode*/ }

                edoc.DocPath = docPath;
                docCol.Add(edoc);
                docCol.DocCount++;
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
                    if (item.ExistInDB && item.DocUpdateType != e_DocAction.D)
                    { item.DocUpdateType = e_DocAction.D; item.HasChange = true; item.ActiveInd = AppKeys.Deactive; }
                    else
                    { docCol.Remove(item);docCol.DocCount--; }
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
                    if (item.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(item.Image))
                        {
                            // Load the image from the memory stream.
                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);
                            pb_viewDoc.Image = bmp;
                            return true;
                        }
                    }
                    else if (File.Exists(item.DocPath))
                    {
                        pb_viewDoc.Image = Image.FromFile(item.DocPath);
                        return true;                  
                    }
                    
                }               
            }          

            if (pb_viewDoc.Image != null){ return true; }
            else { return false; }
            

        }

        private static void HideDoc(PictureBox pb_viewDoc,Panel panel_viewDoc)
        {
            pb_viewDoc.Image = null;
            panel_viewDoc.Visible = false;
        }

        private static bool PopulateDoc(e_DocType e_DocType, DocumentCollection docCol,Label lbl_fileName)
        {
            if (docCol.DocCount > 0)
            {
                foreach (formDocs item in docCol)
                {
                    if (item.DocType.Equals(e_DocType) && item.DocUpdateType != e_DocAction.D)
                    {
                        if (item.DocName.Length > 0)
                        { lbl_fileName.Text = item.DocName; return true; }
                    }
                }                
            }
            return false;
        }

        #endregion SetDocPanel

        #region ContextMenuStrips
        /// <summary>
        /// Conext Menu strip for picture box - mode 1 - ShowPicture, 2 - Save picture
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="mode"></param>
        public static void ContextMenuStrip_pb(PictureBox pb,int option)
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "sahaj");
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            if (option == 1)//Show Picture - Open with windows picture viewer
            {
                pb.Image.Save(path+"\\npbs_tmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Process.Start(path + "\\npbs_tmp.jpg");
            }
            else if (option == 2) //Save image to path
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                               

                dialog.SelectedPath = path;
                dialog.ShowNewFolderButton = true;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (pb != null )
                    {
                        Image im = pb.Image;
                        im.Save(dialog.SelectedPath+"\\npbs_img001.png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                }

               // pb.Image.Save(Environment.SpecialFolder.MyDocuments + "sahaj\\npbs_tmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                Exception Ex = new Exception("Operation Not allowed; option for Context Menu Strip is UnExpected; Source: " + "Utilities.ContextMenuStrip_pb");
                ExceptionManagement.logUserException(Ex);
            }
        }

        #endregion ContextMenuStrips

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
