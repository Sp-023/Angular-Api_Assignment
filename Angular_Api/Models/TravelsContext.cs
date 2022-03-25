using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular_Api.Models
{
    public partial class TravelsContext : DbContext
    {
        public TravelsContext()
        {
        }

        public TravelsContext(DbContextOptions<TravelsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Happytravels> happytravels { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HP-SP\\SQLEXPRESS;Database=Travels;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Happytravels>(entity =>
            {
                entity.ToTable("happytravels");

                entity.Property(e => e.Firstname).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Lastname).HasMaxLength(20);

                entity.Property(e => e.Phoneno).HasMaxLength(20);

                entity.Property(e => e.TravelFrom)
                    .HasColumnName("Travel_From")
                    .HasMaxLength(20);

                entity.Property(e => e.TravelTo)
                    .HasColumnName("Travel_To")
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);*/
    }
}
