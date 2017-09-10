using static m1.Shared.AppCommon;
using static m1.Shared.AppConstants;

namespace m1.Shared.Entities
{
    
    public class FormMessage
    {

        #region Properties

        private string _message = string.Empty;        
        private e_MsgType _messageType;
        private string _retIndicator = string.Empty;

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        public e_MsgType MessageType
        {
            get
            {
                return _messageType;
            }

            set
            {
                _messageType = value;
            }
        }

        public string RetIndicator
        {
            get
            {
                return _retIndicator;
            }

            set
            {
                _retIndicator = value;
            }
        }

        #endregion Properties

    }

   
}
