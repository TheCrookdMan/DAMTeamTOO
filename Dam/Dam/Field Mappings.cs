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
    public class Field_Comp : IEqualityComparer<Field_Mappings>
    {
        public bool Equals(Field_Mappings x, Field_Mappings y)
        {
            return (x as Field_Mappings).Field == (y as Field_Mappings).Field;
        }
        
        public int GetHashCode(Field_Mappings obj)
        {
            // Stores the result.
            int result = 0;

            // Don't compute hash code on null object.
            if (obj == null)
            {
                return 0;
            }

            // Get length.
            int length = obj.Field.Length;

            // Return default code for zero-length strings [valid, nothing to hash with].
            if (length > 0)
            {
                // Compute hash for strings with length greater than 1
                char let1 = obj.Field[0];          // First char of string we use
                char let2 = obj.Field[length - 1]; // Final char

                // Compute hash code from two characters
                int part1 = let1 + length;
                result = (_multiplier * part1) + let2 + length;
            }
            return result;
        }
        const int _multiplier = 89;
    }
}
