using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Data
{
    public class Db : DbContext
    {
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public DbSet<StaffAccount> StaffAccounts { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        public Db(DbContextOptions<Db> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PurchaseRequest>(x =>
            {
                x.Property(c => c.PurchaseRequestID).IsRequired();
                x.Property(c => c.StaffID).IsRequired();
                x.Property(c => c.VendorID).IsRequired();
                x.HasOne(p => p.StaffAccount).WithMany().HasForeignKey(p => p.StaffID).IsRequired();
            });

            modelBuilder.Entity<StaffAccount>(x =>
            {
                x.Property(b => b.StaffID).IsRequired();
                x.Property(p => p.PermissionID).IsRequired();
                x.HasOne(p => p.Permissions).WithMany().HasForeignKey(p => p.PermissionID).IsRequired();
            });

            modelBuilder.Entity<Permission>(x =>
            {
                x.Property(b => b.Name).IsRequired();
            });

            modelBuilder.Entity<PaymentDetail>(x =>
            {
                x.Property(b => b.PaymentDetailsID).IsRequired();
            });



        }
    }
}
