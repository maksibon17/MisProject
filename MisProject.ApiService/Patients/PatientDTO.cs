namespace MisProject.ApiService.Patients
{
    public record PatientDTO(
         string Name,
         string Surname,
         string? Patronymic,
         DateOnly BirthDate,
         string Address,
         string PhoneNumber,
         string MedicalPolicyNumber//Полис ОМС

    );
}
