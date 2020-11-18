namespace QuanLyDoAn.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLDADbContext : DbContext
    {
        public QLDADbContext()
            : base("name=QLDADbContext")
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<QuanLyDoAn.Models.Teacher> Teachers { get; set; }
    }
}
