namespace MisProject.ApiService.Doctors
{
    public class Doctor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Speciality { get; set; }
        public string Position { get; set; } //должность
        public DateOnly EmploymentDate { get; set; } 
    }
}
