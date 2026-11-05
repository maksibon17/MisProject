namespace MisProject.ApiService.Patients
{
    public interface IPatientService
    {
        Task<PatientDTO?> GetPatientByIdAsync(long id);
        Task<IEnumerable<PatientDTO>> GetAllPatientsAsync();
    }
}
