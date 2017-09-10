

namespace m1.Shared.Entities
{
    public class FormMessageCollection:BaseEntityCollection
    {
       
        private bool _hasError = false;
        public bool HasError
        {
            get
            {
                return _hasError;
            }

            set
            {
                _hasError = value;
            }
        }

        #region Collection Methods
        public void Add(FormMessage child)
        {
            List.Add(child);
        }

        public void Remove(FormMessage child)
        {
            List.Remove(child);
        }

        public void Insert(int position, FormMessage child)
        {
            List.Insert(position,child);
        }        

        #endregion Collection Methods
    }


    
}
