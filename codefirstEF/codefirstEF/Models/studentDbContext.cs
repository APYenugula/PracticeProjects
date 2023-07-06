using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Migrations;
namespace codefirstEF.Models {
    public partial class studentDbContext : DbContext
    {

        public studentDbContext()
        {
        }
        public studentDbContext(DbContextOptions<studentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<studenttable> studenttable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=AYENUGUL-L-5517\\SQLEXPRESS;Initial Catalog=studentdb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234;Trust Server Certificate=true");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<studenttable>(entity =>
        //    {
        //        entity.HasKey(e => e.id);

        //        entity.ToTable("studenttable");

        //        entity.Property(e => e.name)
        //            .HasMaxLength(50)
        //            .IsUnicode(false)
        //            .HasColumnName("name");
        //        entity.Property(e => e.standard)
        //            .HasMaxLength(50)
        //            .IsUnicode(false)
        //            .HasColumnName("standard");

        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
