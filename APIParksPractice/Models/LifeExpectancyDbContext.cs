using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIParksPractice.models
{
    public partial class LifeExpectancyDbContext : DbContext
    {
        public LifeExpectancyDbContext()
        {
        }

        public LifeExpectancyDbContext(DbContextOptions<LifeExpectancyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Life> Life { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\sqlexpress;database=LifeExpectancyDb;trusted_connection=true; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
