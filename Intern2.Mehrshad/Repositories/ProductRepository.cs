using Intern2.Mehrshad.MyDbs;
using Intern2.Mehrshad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern2.Mehrshad.Repositories
{
    class ProductRepository
    {
        public MyDb mydb = new MyDb("data source= . ;initial catalog=Intern2 ;integrated security=True; Trusted_Connection=true ;MultipleActiveResultSets=True; TrustServerCertificate=True ;App=EntityFramework");

        public void CreateProduct( CreateProductVm createVm)
        {
            using( var db = new MyDb("data source= . ;initial catalog=Intern2 ;integrated security=True; Trusted_Connection=true ;MultipleActiveResultSets=True; TrustServerCertificate=True ;App=EntityFramework"))
            {
                var cat  = db.Categories.Any(x => x.CategoryID == 1 );

                var z = 0;
            }
        }
    }
}


