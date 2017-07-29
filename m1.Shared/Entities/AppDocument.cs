using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static m1.Shared.AppConstants;

namespace m1.Shared.Entities
{
    class AppDocument
    {
    }
    public class DocumentCollection : BaseEntityCollection
    {

        private AppConstants.e_frmOperationType optype;
        public AppConstants.e_frmOperationType Optype
        {
            get
            {
                return optype;
            }

            set
            {
                optype = value;
            }
        }

        private AppConstants.e_BulkUploadType blkUpdateType;
        public AppConstants.e_BulkUploadType BlkUpdateType
        {
            get
            {
                return blkUpdateType;
            }

            set
            {
                blkUpdateType = value;
            }
        }
        private string _messages = string.Empty;
        private string _RetIndicator = string.Empty;
        public string Messages
        {
            get
            {
                return _messages;
            }

            set
            {
                _messages = value;
            }
        }

        public string RetIndicator
        {
            get
            {
                return _RetIndicator;
            }

            set
            {
                _RetIndicator = value;
            }
        }



        #region Collection Methods
        public void Add(formDocs child)
        {
            List.Add(child);
        }

        public void Remove(formDocs child)
        {
            List.Remove(child);
        }

        public void Insert(int position, EmployeeEntity child)
        {
            List.Insert(position, child);
        }

        //public EmployeeEntity this[int index]
        //{
        //    get { return List[index] as EmployeeEntity; }
        //    set { List[index] = value;}
        //}

        #endregion Collection Methods
    }

    public class formDocs
    {

        #region Properties


        private string _retmessage = string.Empty;
        public string RetMessage
        {
            get
            {
                return _retmessage;
            }

            set
            {
                _retmessage = value;
            }
        }

        private string _retIndicator = string.Empty;
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


        private string _entityId = string.Empty;

        private string _docName = string.Empty;
        private e_DocType _docType;
        private string _docPath = string.Empty;
        private string _docExtn = string.Empty;
        private string _activeInd = string.Empty;
        private string _fileType = string.Empty;
        public byte[] Image = null;



        public string EmpId
        {
            get
            {
                return _entityId;
            }

            set
            {
                _entityId = value;
            }
        }



        public string DocPath
        {
            get
            {
                return _docPath;
            }

            set
            {
                _docPath = value;
            }
        }

        public string FileType
        {
            get
            {
                return _fileType;
            }

            set
            {
                _fileType = value;
            }
        }

        public string DocExtn
        {
            get
            {
                return _docExtn;
            }

            set
            {
                _docExtn = value;
            }
        }

        public e_DocType DocType
        {
            get
            {
                return _docType;
            }

            set
            {
                _docType = value;
            }
        }

        public string ActiveInd
        {
            get
            {
                return _activeInd;
            }

            set
            {
                _activeInd = value;
            }
        }

        public string DocName
        {
            get
            {
                return _docName;
            }

            set
            {
                _docName = value;
            }
        }

        #endregion Properties

    }
}
