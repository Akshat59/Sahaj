using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace m1.DAC
{
    public class QueryConstants
    {
        public const string ValidateUserLogin = "Query_ValidateUserLogin";
        public const string ReadTableData = "SELECT * FROM  {0}";
        public const string GetAppInfo = "Query_GetAppInfo";
        public const string TruncateTable = "TRUNCATE TABLE ";
        public const string InsertEmpDetails = "Query_InsertEmpDetails";
        public const string UpdateEmpDetails = "Query_UpdateEmpDetails";
        public const string TerminateEmp = "Query_TerminateEmp";
        public const string RetrieveEmpDetails = "Query_RetrieveEmpDetails";
        public const string RetrieveEmpDocs = "Query_RetrieveEmpDocs";
        public const string InsertEmpDocs = "Query_InsertEmpDocs";
        public const string UpdateEmpDocs = "Query_UpdateEmpDocs";
        public const string TerminateEmpDocs = "Query_TerminateEmpDocs";
        public const string GetNextID = "Query_GetNextID";
        public const string SearchEntity = "Query_SearchEntity";
        public const string DeleteUserNotes = "Query_DeleteUserNotes";
        public const string InsertUserNotes = "Query_InsertUserNotes";
        public const string RetrieveUserNotes = "Query_RetrieveUserNotes";
        public const string RetrieveUserNoteAlldate = "Query_RetrieveUserNoteAlldate";
    }

    public class DatabaseConstants
    {
        public const string ConnStringKey = "ConnectionStringSQL_Dev";
    }

    

    #region SCRAP
    public class parameterCollection //: ArrayList
    {
        private Parameter _p;
        public Parameter param
        {
            get { return _p; }
            set { _p = value; }
        }


    }
    public class Parameter
    {

        string parameterName;

        public string ParameterName
        {
            get { return parameterName; }
            set { parameterName = value; }
        }
        SqlDbType dbType;

        public SqlDbType DbType
        {
            get { return dbType; }
            set { dbType = value; }
        }
        int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        ParameterDirection direction;

        public ParameterDirection Direction
        {
            get { return direction; }
            set { direction = value; }
        }
    }
    #endregion #region SCRAP
}
