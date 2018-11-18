using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dam
{
    public class DB :DbContext
    {
        public DbSet<Admin> Admins { get; set;  }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Field_Mappings>Field_Mappings { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }
    }
}
