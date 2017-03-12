using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Infrastructure.Data
{
    public class PolishVerbContext : DbContext
    {
        public PolishVerbContext(DbContextOptions<PolishVerbContext> options) : base(options)
        {
        }
        public DbSet<PrimitiveVerb> PrimitiveVerbs { get; set; }
        public DbSet<PolishVerb> PolishVerbs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrimitiveVerb>().ToTable("PrimitiveVerbs");
            modelBuilder.Entity<PolishVerb>().ToTable("PolishVerbs");
        }
    }
}
