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

        public DbSet<Activity> Activity { get; set; }
        public DbSet<AddressInfo> AddressInfo { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Collect> Collect { get; set; }
        public DbSet<Dictionaries> Dictionaries { get; set; }
        public DbSet<DictionariesType> DictionariesType { get; set; }
        public DbSet<Evaluate> Evaluate { get; set; }
        public DbSet<Indent> Indent { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<InformationType> InformationType { get; set; }
        public DbSet<Integral> Integral { get; set; }
        public DbSet<Lease> Lease { get; set; }
        public DbSet<MasterInfo> MasterInfo { get; set; }
        public DbSet<MyBalance> MyBalance { get; set; }
        public DbSet<MyIntegral> MyIntegral { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Probation> Probation { get; set; }
        public DbSet<Search> Search { get; set; }
        public DbSet<Seckill> Seckill { get; set; }
        public DbSet<Shopping> Shopping { get; set; }
        public DbSet<Tourist> Tourist { get; set; }
        public DbSet<TypeInfo> TypeInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Verbose> Verbose { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=169.254.20.176;Initial Catalog=ImageMall;User ID=chaizongze;pwd=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
