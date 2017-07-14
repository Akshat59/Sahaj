

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

        private AppConstants.e_BulkUploadType blkUpdateType;

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

        public EmployeeEntity this[int index]
        {
            get { return List[index] as EmployeeEntity; }
            set {

                if (List == null) { EmployeeCollection q = new EmployeeCollection(); q.Add(value); }
                List[index] = value;
            }
        }

        #endregion Collection Methods
    }
}
