using MisProject.ApiService.Data;
using Microsoft.EntityFrameworkCore;

namespace MisProject.ApiService.Patients
{
    public class PatientService : IPatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PatientDTO>> GetAllPatientsAsync()
        {
            return await _context.Patients
                .Select(patient => new PatientDTO(
                    patient.Name,
                    patient.Surname,
                    patient.Patronymic,
                    patient.BirthDate,
                    patient.Address,
                    patient.PhoneNumber,
                    patient.MedicalPolicyNumber
                ))
                .ToListAsync();
        }
        public async Task<PatientDTO?> GetPatientByIdAsync(long id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                return new PatientDTO(
                patient.Name,
                patient.Surname,
                patient.Patronymic,
                patient.BirthDate,
                patient.Address,
                patient.PhoneNumber,
                patient.MedicalPolicyNumber
                );
            }
            return null;
        }


    }
}
