

namespace m1.Shared.Entities
{
    public class EmployeeCollection:BaseEntityCollection
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
        public void Add(EmployeeEntity child)
        {
            List.Add(child);
        }

        public void Remove(EmployeeEntity child)
        {
            List.Remove(child);
        }

        public void Insert(int position, EmployeeEntity child)
        {
            List.Insert(position,child);
        }

        //public EmployeeEntity this[int index]
        //{
        //    get { return List[index] as EmployeeEntity; }
        //    set { List[index] = value;}
        //}

        #endregion Collection Methods
    }


    
}
