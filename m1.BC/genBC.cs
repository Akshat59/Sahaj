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
    }
}
