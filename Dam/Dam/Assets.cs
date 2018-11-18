using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class Assets
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public Admin CapturedBy { get; set; }
        public DateTime CapturedDate { get; set; }
        public Documents DocID { get; set; }
        public List<Metadata> meta { get; set; }
    }
}
