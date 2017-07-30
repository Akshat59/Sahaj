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
        public const string GetAppInfo = "Query_GetAppInfo";
        public const string TruncateTable = "TRUNCATE TABLE ";
        public const string InsertEmpDetails = "Query_InsertEmpDetails";
        public const string InsertEmpDocs = "Query_InsertEmpDocs";
        public const string GetNextID = "Query_GetNextID";
        public const string SearchEntity = "Query_SearchEntity";  
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
