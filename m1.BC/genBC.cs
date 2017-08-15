using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.Shared.Entities;
using m1.DAC;

namespace m1.BC
{
    public class genBC
    {

        #region Objects
        private genDAC _genDAC;
        public genDAC GenDAC
        {
            get { if (_genDAC == null) { _genDAC = new genDAC(); } return _genDAC; }
        }

        private GenEntity _gEntity;
        public GenEntity GEntity
        {
            get { if (_gEntity == null) { _gEntity = new GenEntity(); } return _gEntity; }
        }
        #endregion


        public bool bcValidateUserLogin(GenEntity GEntity)
        {
            return GenDAC.dacValidateUserLogin(GEntity);
        }



        public bool bcTestDatabaseConnection(GenEntity GEntity)
        {
            return GenDAC.dacTestDatabaseConnection();
        }

        public string  bcGetNextID(string tableName, string sqlColumn, string totallength, string seriesInitials)
        {
            return GenDAC.dacGetNextID(tableName, sqlColumn, totallength, seriesInitials);
        }

        public void bcInsertEmpDetails(EmployeeEntity emp)
        {
            GenDAC.dacInsertEmpDetails(emp);
        }

        public void bcUpdateEmpDetails(EmployeeEntity emp)
        {
            GenDAC.dacUpdateEmpDetails(emp);
        }

        public void bcTerminateEmp(EmployeeEntity emp)
        {
            GenDAC.dacTerminateEmp(emp);
        }

        public void bcInsertEmpDocs(formDocs edoc)
        {
            GenDAC.dacInsertDocs(edoc);
        }

        public void bcUpdateEmpDocs(formDocs edoc)
        {
            GenDAC.dacUpdateEmpDocs(edoc);
        }

        public void bcTerminateEmpDoc(formDocs edoc)
        {
            GenDAC.dacTerminateEmpDoc(edoc);
        }

        public void bcGetEmpDetails(EmployeeEntity m_emp)
        {
            GenDAC.dacGetEmpDetails(m_emp);
        }
        public DocumentCollection bcGetEmpDocs(DocumentCollection m_dcol)
        {
           return GenDAC.dacGetEmpDocs(m_dcol);
        }


        public void bcSearchEntity(SearchEntity se)
        {
            GenDAC.dacSearchEntity(se);
        }
    }
}
