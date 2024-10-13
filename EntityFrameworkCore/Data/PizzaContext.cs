using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class PizzaContext : DbContext       // PizzaContext class is derived from DbContext class
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)       
            // this OnConfiguring method was present in parent class so we overridden it to use here in child class
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-HMP40RGP\SQLEXPRESS;Database=TestDB;Integrated Security=True;");
            // UseSqlServer method is available to us because we install sql server package
        }
    }
}
