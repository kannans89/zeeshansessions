using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfViewModelApp.Business;

namespace WpfViewModelApp.Data
{
    public class CompanyContext : DbContext
    {

        public DbSet<Customer> Customers { get;set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyOrgnization;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}
