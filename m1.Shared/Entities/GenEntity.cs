using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class GenEntity
    {
        public GenEntity()
        {
           userEntity = new UserEntity();
           sessionEntity = new SessionEntity();
            empCollection = new EmployeeCollection();
            commonparamCollection = new CommonParamCollection();
            
        }

        #region Properties
        private SessionEntity sessionEntity;
        public SessionEntity SessionEntity
        {
            get { return sessionEntity; }
            set { sessionEntity = value; }
        }

        private CommonParamCollection commonparamCollection;
        public CommonParamCollection CommonParamCollection
        {
            get { return commonparamCollection; }
            set { commonparamCollection = value; }
        }



        private UserEntity userEntity;
        public UserEntity UserEntity
        {
            get { return userEntity; }
            set { userEntity = value; }
        }

        public EmployeeCollection empCollection { get;  set; }
        //public EmployeeEntity empEntity { get;  set; }
        #endregion
    }
}
