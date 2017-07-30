using System.Data;
using static m1.Shared.AppCommon;
using static m1.Shared.AppConstants;

namespace m1.Shared.Entities
{
    
    public class SearchEntity
    {
        public SearchEntity()
        {
            formMessages = new FormMessageCollection();
        }

        
        #region Properties

        private string _entId = string.Empty;
        private string _name = string.Empty;
        private string _searchField1 = string.Empty;
        private string _searchField2 = string.Empty;
        private string _searchField3 = string.Empty;
        private string _searchField4 = string.Empty;
        private string _searchField5 = string.Empty;
        private string _retCount = string.Empty;
        public DataTable _retDT = new DataTable();
        private string _searchType = string.Empty;

        private FormMessageCollection formMessages;
        public FormMessageCollection FormMessages
        {
            get
            {
                return formMessages;
            }

            set
            {
                formMessages = value;
            }
        }

        public string EntID
        {
            get
            {
                return _entId;
            }

            set
            {
                _entId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string SearchField1
        {
            get
            {
                return _searchField1;
            }

            set
            {
                _searchField1 = value;
            }
        }

        public string SearchField2
        {
            get
            {
                return _searchField2;
            }

            set
            {
                _searchField2 = value;
            }
        }

        public string SearchField3
        {
            get
            {
                return _searchField3;
            }

            set
            {
                _searchField3 = value;
            }
        }

        public string SearchField4
        {
            get
            {
                return _searchField4;
            }

            set
            {
                _searchField4 = value;
            }
        }

        public string SearchField5
        {
            get
            {
                return _searchField5;
            }

            set
            {
                _searchField5 = value;
            }
        }

        public string RetCount
        {
            get
            {
                return _retCount;
            }

            set
            {
                _retCount = value;
            }
        }

        public string SearchType
        {
            get
            {
                return _searchType;
            }

            set
            {
                _searchType = value;
            }
        }





        #endregion Properties

    }


}
