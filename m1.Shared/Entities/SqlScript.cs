using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class SqlScript:BaseEntity
    {
        public SqlScript(string id, string sql)
        {
            this.Key = id;
            this.Script = sql;
        }

        #region Properties
        private string _key = string.Empty;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        private string _script = string.Empty;

        public string Script
        {
            get { return _script; }
            set { _script = value; }
        }
        private List<string> _modifiedTables;

        public List<string> ModifiedTables
        {
            get { return _modifiedTables; }
            set { _modifiedTables = value; }
        }
        #endregion

    
    }
}
