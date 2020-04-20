using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;

namespace WinkelDAL.Context
{
    public class DataAccess:DbContext
    {
        public DataAccess() : base()
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ReadStatus> ReadStatus { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<StockStatus> StockStatus { get; set; }
        public DbSet<Unit> Unit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7NN2PDN1\SQLEXPRESS;Initial Catalog=WinkelDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
