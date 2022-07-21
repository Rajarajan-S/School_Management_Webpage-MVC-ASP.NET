using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CodeFirst.Models
{
    public class DetailsDBcontext : DbContext
    {
        public DetailsDBcontext() : base("name=CF_DB")
        {

        }
        public DbSet<DetailsClass> details { get; set; }
    }
}