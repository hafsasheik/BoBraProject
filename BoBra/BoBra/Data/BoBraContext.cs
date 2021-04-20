using BoBra.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Data
{
    public class BoBraContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<BrokerLogin> BrokerLogins { get; set; }
        public DbSet<Broker_Property> Broker_Properties { get; set; }
        public DbSet<Interest_Reg> Interest_Regs { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }

        public BoBraContext(DbContextOptions<BoBraContext> options) : base(options)
        {

        }

        public DbSet<BoBra.Models.Account> Account { get; set; }
        public DbSet<BoBra.Models.Broker> Broker { get; set; }
        public DbSet<BoBra.Models.BrokerLogin> BrokerLogin { get; set; }
        public DbSet<BoBra.Models.Broker_Property> Broker_Property { get; set; }
        public DbSet<BoBra.Models.Interest_Reg> Interest_Reg { get; set; }
        public DbSet<BoBra.Models.Property> Property { get; set; }
        public DbSet<BoBra.Models.UserLogin> UserLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Måste säga åt entity Framework hur vi vill att denna many-tomany-ralation ska vara. 
        {

            //Broker_Property

            modelBuilder.Entity<Broker_Property>()
                .HasKey(bp => new { bp.BrokerID, bp.PropertyID });

            modelBuilder.Entity<Broker_Property>()
                .HasOne(bp => bp.Broker)
                .WithMany(b => b.Broker_Property)
                .HasForeignKey(bp => bp.BrokerID);

            modelBuilder.Entity<Broker_Property>()
                .HasOne(bp => bp.Property)
                .WithMany(p => p.Broker_Property)
                .HasForeignKey(bp => bp.PropertyID);

            //Interes_Reg

            //modelBuilder.Entity<Interest_Reg>()
            //    .HasKey(pa => new { pa.PropertyID, pa.AccountID });

            //modelBuilder.Entity<Interest_Reg>()
            //    .HasOne(pa => pa.Property)
            //    .WithMany(p => p.Interest_Reg)
            //    .HasForeignKey(pa => pa.PropertyID);

            //modelBuilder.Entity<Interest_Reg>()
            //    .HasOne(pa => pa.Account)
            //    .WithMany(a => a.Interest_Reg)
            //    .HasForeignKey(pa => pa.AccountID);

        }
       
    }
}
