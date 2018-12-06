using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class Documents
    {
        public int ID { get; set; }

        public string Docname { get; set; }
        // navigation property

        public List<Field_Mappings> Fields { get; set; }
        public List<Assets> Asset { get; set; }

        public override string ToString()
        {
            return Docname;
        }
    }
}
