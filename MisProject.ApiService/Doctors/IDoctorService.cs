namespace MisProject.ApiService.Doctors
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDTO>> GetDoctorsAsync(string? speciality);
    }
}