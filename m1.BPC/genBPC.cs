using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.BC;
using m1.Shared.Entities;
using m1.Shared;

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

                if (emp.RetMessage != string.Empty) { _sb.Append(emp.RetMessage); _sb.Append("\r\n"); }
                if(emp.RetIndicator == AppKeys.Failure) { eCol.RetIndicator = AppKeys.Failure; }
               
            }

            eCol.Messages = _sb.ToString();
        }

        public void bpcInsertEmployeeDocs(EmployeeDocsCollection edocCol)
        {
            StringBuilder _sb = new StringBuilder();
            foreach (EmployeeDocs edoc in edocCol)
            {

                GenBC.bcInsertEmpDocs(edoc);

                if (edoc.RetMessage != string.Empty) { _sb.Append(edoc.RetMessage); _sb.Append("\r\n"); }
                if (edoc.RetIndicator == AppKeys.Failure) { edoc.RetIndicator = AppKeys.Failure; }

            }
        }
    }
}
    
