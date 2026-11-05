using Microsoft.EntityFrameworkCore;
using MisProject.ApiService.Data;

namespace MisProject.ApiService.Doctors
{
    public class DoctorService : IDoctorService
    {
        private readonly ApplicationDbContext _context;

        public DoctorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DoctorDTO>> GetDoctorsAsync(string? speciality)
        {
            return await _context.Doctors
                .Where(x => string.IsNullOrEmpty(speciality) || x.Speciality == speciality)
                .Select(doctor => new DoctorDTO(
                    doctor.Name,
                    doctor.Surname,
                    doctor.Patronymic,
                    doctor.BirthDate,
                    doctor.Speciality,
                    doctor.Position,
                    doctor.EmploymentDate
                ))
                .ToListAsync();
        }
    }
}