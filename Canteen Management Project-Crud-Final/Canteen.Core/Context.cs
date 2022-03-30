using Canteen.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core
{
    public class Context : DbContext
    {
        public Context() : base("CanteenConnection")
        {

        }

        public DbSet<Food> Food { get; set; }// model table bind//
        public DbSet<User> User { get; set; }
       
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}
