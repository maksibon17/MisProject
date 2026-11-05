namespace MisProject.ApiService.Doctors
{
    public record DoctorDTO(
         string Name,
         string Surname,
         string? Patronymic,
         DateOnly BirthDate,
         string Speciality,
         string Position, //должность
         DateOnly EmploymentDate
    );
}
