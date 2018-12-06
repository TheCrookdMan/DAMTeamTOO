using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class Field_Mappings
    {
        public int ID { get; set; }
        public string Field { get; set; }
        //navigation property
        public override string ToString()
        {
            return Field;
        }
        public Documents doc { get; set; }
        public List<Metadata> MetaField { get; set; }
    }
    //public class Field_Comp : IEqualityComparer
    //{
       // public new bool Equals(object x, object y)
       // {
          //  throw (x as Field_Mappings).Field == (y as Field_Mappings).Field;
       // }

      //  public int GetHashCode(object obj)
      //  {
      //      throw new NotImplementedException();
      //  }
   // }
}
