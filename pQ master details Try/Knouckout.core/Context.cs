using Knockout.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knouckout.core
{
    class Context: DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();// plularise db table naming convension off--entity behaviour
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Food> Food/*Master*/ { get; set; }
        public DbSet<Orders> OrderList/*Details*/ { get; set; }

       
    }
}
