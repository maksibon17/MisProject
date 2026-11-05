namespace MisProject.ApiService.Patients
{
    public class Patient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MedicalPolicyNumber { get; set; } //Полис ОМС

    }
}
