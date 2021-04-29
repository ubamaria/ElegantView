using DBImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DBImplement
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BUNOAQN\SQLEXPRESS;Initial Catalog=DatabaseElegant;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<Production> Productions { set; get; }

        public virtual DbSet<Request> Requests { set; get; }
    }
}
