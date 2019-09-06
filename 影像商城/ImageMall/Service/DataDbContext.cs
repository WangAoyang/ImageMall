using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class DataDbContext:DbContext
    {
        public DataDbContext()
        {

        }
        public DataDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Activity> Activityset { get; set; }
        public DbSet<AddressInfo> AddressInfoset { get; set; }
        public DbSet<Application> Applicationset { get; set; }
        public DbSet<Collect> Collectset { get; set; }
        public DbSet<Dictionaries> Dictionariesset { get; set; }
        public DbSet<DictionariesType> DictionariesTypeset { get; set; }
        public DbSet<Evaluate> Evaluateset { get; set; }
        public DbSet<Indent> Indentset { get; set; }
        public DbSet<Information> Informationset { get; set; }
        public DbSet<InformationType> InformationTypeset { get; set; }
        public DbSet<Integral> Integralset { get; set; }
        public DbSet<Lease> Leaseset { get; set; }
        public DbSet<MasterInfo> MasterInfoset { get; set; }
        public DbSet<MyBalance> MyBalanceset { get; set; }
        public DbSet<MyIntegral> MyIntegralset { get; set; }
        public DbSet<Picture> Pictureset { get; set; }
        public DbSet<Probation> Probationset { get; set; }
        public DbSet<Search> Searchset { get; set; }
        public DbSet<Seckill> Seckillset { get; set; }
        public DbSet<Shopping> Shoppingset { get; set; }
        public DbSet<Tourist> Touristset { get; set; }
        public DbSet<TypeInfo> TypeInfoset { get; set; }
        public DbSet<UserInfo> UserInfoset { get; set; }
        public DbSet<Verbose> Verboseset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=169.254.20.176;Initial Catalog=1612;User ID=wangaoyang;pwd=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
