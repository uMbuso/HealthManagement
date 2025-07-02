using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblpatientprofile
{
    public int PatientProfileId { get; set; }

    public int PatientId { get; set; }

    public string NextOfKinFullName { get; set; } = null!;

    public string NextOfKinTel { get; set; } = null!;

    public int? MedicalInsuranceDetailId { get; set; }

    public string? FamilyDoctorFullName { get; set; }

    public string? FamilyDoctorTel { get; set; }

    public string? FamilyHistory { get; set; }

    public int ImmunityStatusId { get; set; }

    public decimal BodyMass { get; set; }

    public decimal Height { get; set; }

    public decimal? Bmi { get; set; }

    public decimal? Bsa { get; set; }

    public string? SurgicalHistoryOperations { get; set; }

    public string? DrugAllergies { get; set; }

    public string? PorphyriaAndParadoxical { get; set; }

    public string? DietAndLifestyle { get; set; }

    public bool Smoker { get; set; }

    public string? AlcoholConsumption { get; set; }

    public string? CaffeineIntake { get; set; }

    public string? MedicationHistory { get; set; }

    public string? AcuteMedication { get; set; }

    public string? ChronicMedication { get; set; }

    public int ContraceptionTypeId { get; set; }

    public int? FirstDayOfMenses { get; set; }

    public bool? Pregnant { get; set; }

    public string? BloodPressure { get; set; }

    public decimal? BodyTemperature { get; set; }

    public int? Pulse { get; set; }

    public int? RespiratoryRate { get; set; }

    public string? Other { get; set; }

    public string? Hydration { get; set; }

    public string? Jaundice { get; set; }

    public string? Cyanosis { get; set; }

    public string? OtherPhysical { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
