using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace m1.Shared.Entities
{
    [Serializable()]
    public abstract class BaseEntity:ICloneable
    {
        public virtual object Clone()
        {
            MemoryStream _buffer = new MemoryStream();
            BinaryFormatter _formatter = new BinaryFormatter();

            _formatter.Serialize(_buffer, this);
            _buffer.Position = 0;
            return _formatter.Deserialize(_buffer);

        }

        public virtual bool IsValid
        {
            get
            {
                return true;
            }

        }
    }
}
