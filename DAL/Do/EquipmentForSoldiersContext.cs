using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Do;

public partial class EquipmentForSoldiersContext : DbContext
{
    public EquipmentForSoldiersContext(DbContextOptions<EquipmentForSoldiersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<IdfbaseKindOfVolunteering> IdfbaseKindOfVolunteerings { get; set; }

    public virtual DbSet<Idfbasis> Idfbases { get; set; }

    public virtual DbSet<KindOfVolunteering> KindOfVolunteerings { get; set; }

    public virtual DbSet<Volunteer> Volunteers { get; set; }

    public virtual DbSet<VolunteersKindOfVolunteering> VolunteersKindOfVolunteerings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__City__3214EC07D68A25C8");

            entity.ToTable("City");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<IdfbaseKindOfVolunteering>(entity =>
        {
            entity.HasKey(e => e.JunctionId).HasName("PK__IDFBaseK__5334302B5FE4F83C");

            entity.ToTable("IDFBaseKindOfVolunteering");

            entity.Property(e => e.IdfbaseId).HasColumnName("IDFBaseId");

            entity.HasOne(d => d.Idfbase).WithMany(p => p.IdfbaseKindOfVolunteerings)
                .HasForeignKey(d => d.IdfbaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IDFBaseKindOfVolunteering_IDFBases");
        });

        modelBuilder.Entity<Idfbasis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IDFBases__3214EC070A275EBC");

            entity.ToTable("IDFBases");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.Idfbases)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_IDFBases_CityId");
        });

        modelBuilder.Entity<KindOfVolunteering>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KindOfVo__3214EC0704A5C058");

            entity.ToTable("KindOfVolunteering");

            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<Volunteer>(entity =>
        {
            entity.HasKey(e => e.VolunteerId).HasName("PK__Voluntee__716F6FCC133ADE84");

            entity.Property(e => e.VolunteerId)
                .ValueGeneratedNever()
                .HasColumnName("VolunteerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaleOrFemale)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.Volunteers)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_CityId");
        });

        modelBuilder.Entity<VolunteersKindOfVolunteering>(entity =>
        {
            entity.HasKey(e => e.JunctionId).HasName("PK__Voluntee__5334302B5EF6E029");

            entity.ToTable("VolunteersKindOfVolunteering");

            entity.HasOne(d => d.Volunteers).WithMany(p => p.VolunteersKindOfVolunteerings)
                .HasForeignKey(d => d.VolunteersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VolunteersKindOfVolunteering_Volunteers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
