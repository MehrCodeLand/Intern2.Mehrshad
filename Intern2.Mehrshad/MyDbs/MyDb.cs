using Leyer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern2.Mehrshad.MyDbs
{
    class MyDb : DbContext
    {
        public MyDb(string connectionString ) : base(connectionString)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}
