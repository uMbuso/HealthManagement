using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Pill_eHealth.Entities;

public partial class ThepillcPillEhealthContext : DbContext
{
    public ThepillcPillEhealthContext()
    {
    }

    public ThepillcPillEhealthContext(DbContextOptions<ThepillcPillEhealthContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tblapprole> Tblapproles { get; set; }

    public virtual DbSet<Tblappuser> Tblappusers { get; set; }

    public virtual DbSet<Tblappuserinrole> Tblappuserinroles { get; set; }

    public virtual DbSet<Tblappuserstatus> Tblappuserstatuses { get; set; }

    public virtual DbSet<Tblappusertype> Tblappusertypes { get; set; }

    public virtual DbSet<Tblpatient> Tblpatients { get; set; }

    public virtual DbSet<Tblpatientprofile> Tblpatientprofiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tblapprole>(entity =>
        {
            entity.HasKey(e => e.AppRoleId).HasName("PRIMARY");

            entity.ToTable("tblapprole");

            entity.Property(e => e.AppRoleId).HasColumnType("int(11)");
            entity.Property(e => e.AppRole).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Tblappuser>(entity =>
        {
            entity.HasKey(e => e.AppUserId).HasName("PRIMARY");

            entity.ToTable("tblappuser");

            entity.Property(e => e.AppUserId).HasColumnType("int(11)");
            entity.Property(e => e.AppUserName).HasMaxLength(25);
            entity.Property(e => e.AppUserStatusId).HasColumnType("int(11)");
            entity.Property(e => e.AppUserTypeId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.MiddleNames)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.PrimaryTel).HasMaxLength(20);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<Tblappuserinrole>(entity =>
        {
            entity.HasKey(e => e.AppUserInRoleId).HasName("PRIMARY");

            entity.ToTable("tblappuserinrole");

            entity.Property(e => e.AppUserInRoleId).HasColumnType("int(11)");
            entity.Property(e => e.AppRoleId).HasColumnType("int(11)");
            entity.Property(e => e.AppUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Tblappuserstatus>(entity =>
        {
            entity.HasKey(e => e.AppUserStatusId).HasName("PRIMARY");

            entity.ToTable("tblappuserstatus");

            entity.Property(e => e.AppUserStatusId).HasColumnType("int(11)");
            entity.Property(e => e.AppUserStatus).HasMaxLength(25);
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Tblappusertype>(entity =>
        {
            entity.HasKey(e => e.AppUserTypeId).HasName("PRIMARY");

            entity.ToTable("tblappusertype");

            entity.Property(e => e.AppUserTypeId).HasColumnType("int(11)");
            entity.Property(e => e.AppUserType).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Tblpatient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PRIMARY");

            entity.ToTable("tblpatient");

            entity.Property(e => e.PatientId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.MiddleNames)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.Occupation).HasMaxLength(100);
            entity.Property(e => e.PrimaryTel).HasMaxLength(20);
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        modelBuilder.Entity<Tblpatientprofile>(entity =>
        {
            entity.HasKey(e => e.PatientProfileId).HasName("PRIMARY");

            entity.ToTable("tblpatientprofile");

            entity.Property(e => e.PatientProfileId).HasColumnType("int(11)");
            entity.Property(e => e.AcuteMedication)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.AlcoholConsumption)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.BloodPressure)
                .HasMaxLength(7)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Bmi)
                .HasPrecision(3, 1)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("BMI");
            entity.Property(e => e.BodyMass).HasPrecision(5);
            entity.Property(e => e.BodyTemperature)
                .HasPrecision(3, 1)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Bsa)
                .HasPrecision(3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("BSA");
            entity.Property(e => e.CaffeineIntake)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.ChronicMedication)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.ContraceptionTypeId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.Cyanosis)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.DietAndLifestyle)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.DrugAllergies)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("Drug Allergies");
            entity.Property(e => e.FamilyDoctorFullName)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.FamilyDoctorTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.FamilyHistory)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.FirstDayOfMenses)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Height).HasPrecision(3);
            entity.Property(e => e.Hydration)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.ImmunityStatusId).HasColumnType("int(11)");
            entity.Property(e => e.Jaundice)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.MedicalInsuranceDetailId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.MedicationHistory)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.ModifiedByUserId).HasColumnType("int(11)");
            entity.Property(e => e.ModifiedDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime");
            entity.Property(e => e.NextOfKinFullName).HasMaxLength(250);
            entity.Property(e => e.NextOfKinTel).HasMaxLength(20);
            entity.Property(e => e.Other)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.OtherPhysical)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.PatientId).HasColumnType("int(11)");
            entity.Property(e => e.PorphyriaAndParadoxical)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.Pregnant).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Pulse)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.RespiratoryRate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.SurgicalHistoryOperations)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
