using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPBX.DAL.Models;

namespace VirtualPBX.DAL.DataAccess
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<CallLog> CallLogs { get; set; } = null!;
        public DbSet<Email> Emails { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Phone> Phones { get; set; } = null!;
        public DbSet<Profile> Profiles { get; set; } = null!;
        public DbSet<Rate> Rates { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallLog>()
                .HasOne(i => i.IncomingCall)
                .WithMany(p => p.IncomingCalls)
                .HasForeignKey(k => k.IncomingCallKey);

            modelBuilder.Entity<CallLog>()
                .HasOne(o => o.OutgoingCall)
                .WithMany(p => p.OutgoingCalls)
                .HasForeignKey(k => k.OutgoingCallKey);
        }
    }
}
