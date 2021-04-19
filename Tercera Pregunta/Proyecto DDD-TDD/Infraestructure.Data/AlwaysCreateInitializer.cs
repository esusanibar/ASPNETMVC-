using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class AlwaysCreateInitializer2 : DropCreateDatabaseAlways<EmpresaContext>
    {
        protected override void Seed(EmpresaContext context)
        {
            //var listCountry = new List<Cliente>() {
            //   new Cliente() { Id = 1, Name = "US" },
            //   new Cliente() { Id = 2, Name = "India" },
            //   new Cliente() { Id = 3, Name = "Russia" }
            //};

            //context.Countries.AddRange(listCountry);

            //context.SaveChanges();

            //base.Seed(context);
        }
    }
}
