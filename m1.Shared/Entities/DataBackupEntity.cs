using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class DataBackupEntity
    {

        public DataBackupEntity()
        {

        }


        private string tableName = string.Empty;
        private string returnInd;
        private string returnMessage = string.Empty;
        private DataSet resultDataSet = new DataSet();

        public DataSet ResultDataSet
        {
            get
            {
                return resultDataSet;
            }

            set
            {
                resultDataSet = value;
            }
        }

        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }

        public string ReturnInd
        {
            get
            {
                return returnInd;
            }

            set
            {
                returnInd = value;
            }
        }

        public string ReturnMessage
        {
            get
            {
                return returnMessage;
            }

            set
            {
                returnMessage = value;
            }
        }
    }
}
