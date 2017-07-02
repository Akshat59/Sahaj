using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.Shared.Entities;
using System.Collections;

namespace m1.Shared.Collections
{
    [Serializable()]
    public class SqlScriptCollection//:ICollection<SqlScript>
    {
        private SortedList<string, SqlScript> scripts =
            new SortedList<string, SqlScript>(StringComparer.CurrentCultureIgnoreCase);

        public void Add(SqlScript child){scripts.Add(child.Key, child);}

        public bool Remove(SqlScript Child) {return scripts.Remove(Child.Key);}

        public int Count { get { return scripts.Count; } }

        public void Clear() { scripts.Clear(); }

        public bool Contains(SqlScript script) {return scripts.ContainsKey(script.Key);}

        //IEnumerator<SqlScript> IEnumerable<SqlScript>.GetEnumerator() {return scripts.Values.GetEnumerator();}

        //IEnumerator IEnumerable.GetEnumerator() { return scripts.Values.GetEnumerator(); }


    }
}
