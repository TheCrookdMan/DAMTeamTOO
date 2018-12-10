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

        public override string ToString()
        {
            return $"{ID}: {Location.Split('\\').Last()} {spacecount(Location.Split('/').Last())} [{DocID.Asset}]";
        }
        
        private object spacecount(string v)
        {
            try
            {
                string Return = "                         ";
                foreach (var item in v)
                {
                    Return.Substring(1);
                }
                return Return;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
