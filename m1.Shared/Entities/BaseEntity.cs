using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    [Serializable()]
    public abstract class BaseEntity//:ICloneable
    {
        public virtual void Clone()
        {
            //object q = new object();

            //return q;
        }

       
    }
}
