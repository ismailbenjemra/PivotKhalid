using Microsoft.EntityFrameworkCore;
using Synapse.Infrastructure;
using Synapse.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Synapse.Infrastructure
{
    public class SynapseDBContext : DbContext
    {
        public SynapseDBContext(DbContextOptions<SynapseDBContext> options):base(options)
        {
        }

        public DbSet<Cre> CreSet { get; set; }
        public DbSet<Ssa> SsaSet { get; set; }
        public DbSet<Histories> HistorySet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OE8AEG7\SQLEXPRESS;Initial Catalog=SynapseDb;Integrated Security=True");
        }
    }
}
