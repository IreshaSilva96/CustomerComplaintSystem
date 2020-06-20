using System;
using CustomerComplaintSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerComplaintSystem.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<AccountHolder> AccountHolder { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<AgentType> AgentType { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<CategoryOfComplaint> CategoryOfComplaint { get; set; }
        public DbSet<Complaint> Complaint { get; set; }
        public DbSet<ComplaintStatus> ComplaintStatus { get; set; }
        public DbSet<CustomerType> CustomerType { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<NatureOfComplaint> NatureOfComplaint { get; set; }
        public DbSet<ProductAndService> ProductAndService { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder build)
        {
            string SQLConnectionString = "Server=localhost,1433; Database=DBCustomerComplaintSystem; User=sa; Password=Admin@123;";

            build.UseSqlServer(SQLConnectionString);

            base.OnConfiguring(build);
        }
    }
}
