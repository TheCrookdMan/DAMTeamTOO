using System;
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

        public Documents doc { get; set; }

        public List<Metadata> MetaField { get; set; }
    }
}
