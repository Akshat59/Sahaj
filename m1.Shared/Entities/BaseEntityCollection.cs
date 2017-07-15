using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace m1.Shared.Entities
{
    public abstract class BaseEntityCollection:CollectionBase,ICloneable
    {

        #region Contains
        public virtual bool Contains(BaseEntity item)
        {
            foreach (BaseEntity be in List)
            {
                if (be.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        public virtual bool IsValid
        {
            get
            {
                foreach (BaseEntity be in List)
                {
                    if(be.IsValid == false)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public virtual object Clone()
        {
            MemoryStream _buffer = new MemoryStream();
            BinaryFormatter _formatter = new BinaryFormatter();

            _formatter.Serialize(_buffer, this);
            _buffer.Position = 0;
            return _formatter.Deserialize(_buffer);

        }

        public virtual BaseEntity Search(string propertyName,object propertyValue,bool ignoreCase, bool alreadySorted)
        {
            if(alreadySorted == false)
            { Sort(propertyName, 1); } //1 -Ascending  2- Descending

            IComparer search = new ReflectionSearch(propertyName, ignoreCase);
            int ret = this.InnerList.BinarySearch(propertyValue, search);
            if(ret > -1) { return (BaseEntity)this.InnerList[ret]; }
            else { return null; }
        }

        private void Sort(string propertyName, object sortDirection)
        {
            //IComparer sort = new ReflectionSearch(propertyName, sortDirection);
        }


        public override bool Equals(object obj)
        {
            MemoryStream bufsource = new MemoryStream();
            MemoryStream buftarget = new MemoryStream();

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(bufsource, this);
            formatter.Serialize(buftarget, this);

            string source = Convert.ToBase64String(bufsource.ToArray());
            string target = Convert.ToBase64String(buftarget.ToArray());

            if (source == target) { return true; }
            else { return false; }
            
        }

        //protected IList List { get; }
    }

    internal class ReflectionSearch : IComparer
    {

        string _propertyName = string.Empty;
        bool _ignoreCase = false;

        public ReflectionSearch(string propertyName,bool ignoreCase)
        {
            this._propertyName = propertyName;
            this._ignoreCase = ignoreCase;
        }

        public int Compare(object x,object y)
        {

            return 1;
        }

    }
}