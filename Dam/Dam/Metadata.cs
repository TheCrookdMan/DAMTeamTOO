using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class Metadata
    {
        public int ID { get; set; }
        public Documents document { get; set; }
        public string FieldValue{ get; set; }
        public Assets AssetMeta { get; set; }
        public Field_Mappings FieldMeta { get; set; }

    }
}
