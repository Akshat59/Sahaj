using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class SessionEntity
    {
        #region Properties
        private string _SqlLog = string.Empty;

        public string SqlLog
        {
            get { return _SqlLog; }
            set { _SqlLog = value; }
        }
        #endregion Properties
    }
}
