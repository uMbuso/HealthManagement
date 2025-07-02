using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pill_eHealth.DTO;
using Pill_eHealth.Entities;
using System.Net;
using System.Net.Mail;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pill_eHealth.Controllers
{
    [EnableCors("_PillAllowSpecificOrigins")]
    [Route("api/Patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ThepillcPillEhealthContext dbContext;

        public PatientsController(ThepillcPillEhealthContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // GET: api/<PatientsController>
        [HttpGet("GetPatients")]
        public async Task<ActionResult<List<PatientDTO>>> GetPatients()
        {
            var List = await dbContext.Tblpatients.Select(
                s => new PatientDTO
                {
                    PatientId = s.PatientId,
                    Surname = s.Surname,
                    MiddleNames = s.MiddleNames,
                    FirstName = s.FirstName,
                    PrimaryTel = s.PrimaryTel,
                    EmailAddress = s.EmailAddress,
                    Sex = s.Sex,
                    Dob = s.Dob,
                    Occupation = s.Occupation,
                    CreatedDateTime = s.CreatedDateTime,
                    CreatedByUserId = s.CreatedByUserId,
                    ModifiedDateTime = s.ModifiedDateTime,
                    ModifiedByUserId = s.ModifiedByUserId
                }
             ).ToListAsync();

            if(List.Count < 0 )
            {
                return NotFound();
            }
            else
            {
                return List;
            }
        }

        // GET api/<PatientsController>/5
        [HttpGet("GetPatientBySystemId")]
        public async Task<ActionResult<PatientDTO>> GetPatientBySystemId(int id)
        {
            PatientDTO Patient = await dbContext.Tblpatients.Select(
                s => new PatientDTO 
                { 
                    PatientId = s.PatientId, 
                    Surname = s.Surname,
                    MiddleNames = s.MiddleNames,
                    FirstName = s.FirstName,
                    PrimaryTel = s.PrimaryTel,
                    EmailAddress = s.EmailAddress,
                    Sex = s.Sex,
                    Dob = s.Dob,
                    Occupation = s.Occupation,
                    CreatedDateTime = s.CreatedDateTime,
                    CreatedByUserId = s.CreatedByUserId,
                    ModifiedDateTime = s.ModifiedDateTime,
                    ModifiedByUserId = s.ModifiedByUserId
                }).FirstOrDefaultAsync(s => s.PatientId == id);

            if(Patient == null ) 
            {
                return NotFound();
            }
            else
            {
                return Patient;
            }
        }

        // GET api/<PatientsController>/5
        [HttpGet("GetPatientByMSISDN")]
        public async Task<ActionResult<PatientDTO>> GetPatientByMSISDN(string MSISDN)
        {
            PatientDTO Patient = await dbContext.Tblpatients.Select(
                s => new PatientDTO
                {
                    PatientId = s.PatientId,
                    Surname = s.Surname,
                    MiddleNames = s.MiddleNames,
                    FirstName = s.FirstName,
                    PrimaryTel = s.PrimaryTel,
                    EmailAddress = s.EmailAddress,
                    Sex = s.Sex,
                    Dob = s.Dob,
                    Occupation = s.Occupation,
                    CreatedDateTime = s.CreatedDateTime,
                    CreatedByUserId = s.CreatedByUserId,
                    ModifiedDateTime = s.ModifiedDateTime,
                    ModifiedByUserId = s.ModifiedByUserId
                }).FirstOrDefaultAsync(s => s.PrimaryTel == MSISDN);

            if (Patient == null)
            {
                return NotFound();
            }
            else
            {
                return Patient;
            }
        }

        // POST api/<PatientsController>
        [HttpPost("CreatePatient")]
        public async Task<HttpStatusCode> CreatePatient(PatientDTO Patient)
        {
            var entity = new Tblpatient()
            {
                Surname = Patient.Surname,
                MiddleNames = Patient.MiddleNames,
                FirstName = Patient.FirstName,
                PrimaryTel = Patient.PrimaryTel,
                EmailAddress = Patient.EmailAddress,
                Sex = Patient.Sex,
                Dob = Patient.Dob,
                Occupation = Patient.Occupation,
                CreatedDateTime = Patient.CreatedDateTime,
                CreatedByUserId = Patient.CreatedByUserId,
                ModifiedDateTime = Patient.ModifiedDateTime,
                ModifiedByUserId = Patient.ModifiedByUserId
            };

            dbContext.Tblpatients.Add(entity);
            await dbContext.SaveChangesAsync();

            return HttpStatusCode.Created;
        }

        // PUT api/<PatientsController>/5
        [HttpPut("UpdatePatient")]
        public async Task<HttpStatusCode> UpdatePatient(PatientDTO Patient)
        {
            var entity = await dbContext.Tblpatients.FirstOrDefaultAsync(s => s.PatientId == Patient.PatientId);
            
            entity.Surname = Patient.Surname;
            entity.MiddleNames = Patient.MiddleNames;
            entity.FirstName = Patient.FirstName;
            entity.PrimaryTel = Patient.PrimaryTel;
            entity.EmailAddress = Patient.EmailAddress;
            entity.Sex = Patient.Sex;
            entity.Dob = Patient.Dob;
            entity.Occupation = Patient.Occupation;
            entity.CreatedDateTime = Patient.CreatedDateTime;
            entity.CreatedByUserId = Patient.CreatedByUserId;
            entity.ModifiedDateTime = Patient.ModifiedDateTime;
            entity.ModifiedByUserId = Patient.ModifiedByUserId;

            await dbContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        // DELETE api/<PatientsController>/5
        [HttpDelete("DeletePatient")]
        public async Task<HttpStatusCode> DeletePatient(int id)
        {
            var entity = new Tblpatient()
            { 
                PatientId = id
            };
            dbContext.Tblpatients.Attach(entity);
            dbContext.Tblpatients.Remove(entity);
            await dbContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }
}
