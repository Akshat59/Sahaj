using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.BC;
using m1.Shared.Entities;
using m1.Shared;
using static m1.Shared.Utilities;

namespace m1.BPC
    {
        public class genBPC
        {


            #region Constructor

            #endregion

            #region Objects
            private genBC _genBC;
            public genBC GenBC
            {
                get { if (_genBC == null) { _genBC = new genBC(); } return _genBC; }
            }

            private GenEntity _gEntity;
            public GenEntity GEntity
            {
                get { if (_gEntity == null) { _gEntity = new GenEntity(); } return _gEntity; }
            }
            #endregion

            #region Properties

            #endregion

            #region Controls

            #endregion

            #region PrivateMethods

            #endregion

            public bool bpcValidateUserLogin(GenEntity GEntity)
            {
                return GenBC.bcValidateUserLogin(GEntity);
            }

            public void initializeDisplay_Welcome( )
            {
                
            }

            public void setLogonInfo(GenEntity GEntity)
            {
                throw new NotImplementedException();
            }

            public bool bpcTestDatabaseConnection(GenEntity GEntity)
            {
                return GenBC.bcTestDatabaseConnection(GEntity);
            }

        public void bpcGetUserNotes(UserEntity userEntity)
        {
            GenBC.bcGetUserNotes(userEntity);
        }

        public void bpcSaveUserNotes(UserEntity userEntity)
        {
            GenBC.bcDeleteUserNotes(userEntity);
            if (!userEntity.UserNoteText.Equals(string.Empty))
            { GenBC.bcSaveUserNotes(userEntity); }
        }

        public string bpcGetNextID (string tableName, string columnName,string columnLen,string seriesInitals)
        {
            return GenBC.bcGetNextID(tableName, columnName, columnLen, seriesInitals);
        }

        public void bpcInsertEmployeeDetails(EmployeeCollection eCol)
        {
            StringBuilder _sb = new StringBuilder();
            string _seriesInitals = string.Empty;
            eCol.RetIndicator = AppKeys.Success;

            foreach (EmployeeEntity emp in eCol)
            {
                GenBC.bcInsertEmpDetails(emp);

                if (emp.RetMessage != string.Empty)
                {
                    FormMessage fm = new FormMessage();
                    fm.Message = emp.RetMessage;
                    if (emp.RetIndicator == AppKeys.Failure)
                    { fm.MessageType = AppConstants.e_MsgType.E; }
                    else { fm.MessageType = AppConstants.e_MsgType.A; }
                    eCol.FormMessages.Add(fm);
                }
                if (emp.RetIndicator == AppKeys.Failure) { eCol.RetIndicator = AppKeys.Failure; }
               
            }

            eCol.Messages = _sb.ToString();
        }



        public void bpcUpdateEmployeeDetails(EmployeeCollection eCol)
        {
            StringBuilder _sb = new StringBuilder();
            string _seriesInitals = string.Empty;
            eCol.RetIndicator = AppKeys.Success;

            foreach (EmployeeEntity emp in eCol)
            {
                GenBC.bcUpdateEmpDetails(emp);

                if (emp.RetMessage != string.Empty)
                {
                    FormMessage fm = new FormMessage();
                    fm.Message = emp.RetMessage;
                    if (emp.RetIndicator == AppKeys.Failure)
                    { fm.MessageType = AppConstants.e_MsgType.E; }
                    else { fm.MessageType = AppConstants.e_MsgType.A; }
                    eCol.FormMessages.Add(fm);
                }
                if (emp.RetIndicator == AppKeys.Failure) { eCol.RetIndicator = AppKeys.Failure; }

            }

            eCol.Messages = _sb.ToString();
        }


        public void bpcTerminateEmployee(EmployeeCollection eCol)
        {
            StringBuilder _sb = new StringBuilder();
            string _seriesInitals = string.Empty;
            eCol.RetIndicator = AppKeys.Success;

            foreach (EmployeeEntity emp in eCol)
            {
                GenBC.bcTerminateEmp(emp);

                if (emp.RetMessage != string.Empty)
                {
                    FormMessage fm = new FormMessage();
                    fm.Message = emp.RetMessage;
                    if (emp.RetIndicator == AppKeys.Failure)
                    { fm.MessageType = AppConstants.e_MsgType.E; }
                    else { fm.MessageType = AppConstants.e_MsgType.A; }
                    eCol.FormMessages.Add(fm);
                }
                if (emp.RetIndicator == AppKeys.Failure) { eCol.RetIndicator = AppKeys.Failure; }

            }

            eCol.Messages = _sb.ToString();
        }

        public void bpcSearchEntity(SearchEntity se)
        {
            GenBC.bcSearchEntity(se);
        }

        public void bpcInsertEmployeeDocs(DocumentCollection edocCol)
        {
            FormMessageCollection fmCol = new FormMessageCollection();
            FormMessage fm = new FormMessage();

            foreach (formDocs edoc in edocCol)
            {
                GenBC.bcInsertEmpDocs(edoc);

                if (edoc.RetIndicator == AppKeys.Failure)
                {
                    edocCol.RetIndicator = AppKeys.Failure;
                }

            }

            if (edocCol.RetIndicator == AppKeys.Failure)
            { fm.Message = UserMessages.InsertEmpDocFailure; fmCol.Add(fm); }
            else if (edocCol.RetIndicator == AppKeys.Failure && edocCol.Count > 0)
            { fm.Message = UserMessages.InsertEmpDocSuccess; edocCol.RetIndicator = AppKeys.Success; fmCol.Add(fm); }

            edocCol.FormMessages = fmCol;
        }

        public void bpcUpdateEmployeeDocs(DocumentCollection edocCol)
        {            
            FormMessageCollection  fmCol= new FormMessageCollection();
            FormMessage fm = new FormMessage();

            foreach (formDocs edoc in edocCol)
            {
                if (edoc.DocUpdateType == e_DocAction.M && edoc.HasChange)
                { GenBC.bcUpdateEmpDocs(edoc); }
                else if (edoc.DocUpdateType == e_DocAction.U && edoc.HasChange)
                { GenBC.bcInsertEmpDocs(edoc); }
                else if (edoc.DocUpdateType == e_DocAction.D && edoc.HasChange)
                { GenBC.bcTerminateEmpDoc(edoc); }
                else { //Ignore
                    /*log alert as no action taken #futureCode*/
                }

                if (edoc.RetIndicator == AppKeys.Failure)
                {
                    edocCol.RetIndicator = AppKeys.Failure;                    
                }
            }

           
            if (edocCol.RetIndicator == AppKeys.Failure)
            { fm.Message = UserMessages.UpdateEmpDocFailure; fmCol.Add(fm); }
            else if(edocCol.RetIndicator == AppKeys.Failure&&edocCol.Count>0)
            { fm.Message = UserMessages.UpdateEmpDocSuccess; edocCol.RetIndicator = AppKeys.Success; fmCol.Add(fm); }

            edocCol.FormMessages = fmCol;
        }
        public void bpcTerminateEmployeeDocs(DocumentCollection edocCol)
        {

            foreach (formDocs edoc in edocCol)
            {
                GenBC.bcTerminateEmpDoc(edoc);

                if (edoc.RetIndicator == AppKeys.Failure)
                {
                    edocCol.RetIndicator = AppKeys.Failure;
                }
            }

            FormMessage fm = new FormMessage();
            if (edocCol.RetIndicator == AppKeys.Failure)
            { fm.Message = UserMessages.InsertEmpDocFailure; }
            else { fm.Message = UserMessages.DatabaseUpdateFailure; }
            edocCol.FormMessages.Add(fm);
        }


        public void bpcGetEmpDetails(EmployeeCollection m_eCol)
        {            
            foreach (EmployeeEntity m_emp in m_eCol)
            {                
                GenBC.bcGetEmpDetails(m_emp);                
                if(m_emp.RetIndicator == AppKeys.Failure)
                { m_eCol.RetIndicator = AppKeys.Failure; m_eCol.Messages = UserMessages.RetrieveEmpFailed; }
            }
        }

        public DocumentCollection bpcGetEmpDocs(DocumentCollection m_dCol)
        {            
            return GenBC.bcGetEmpDocs(m_dCol);            
        }
    }
}
    
