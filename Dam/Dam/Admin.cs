using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class Admin
    {
        public int ID { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string Position { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNo { get; set; }

        //navigation properties
        public  List<Assets> CapturedAssets { get; set; }
    }
}
