using Microsoft.EntityFrameworkCore;
using MisProject.ApiService.Diseases;
using MisProject.ApiService.Doctors;
using MisProject.ApiService.Patients;

namespace MisProject.ApiService.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            await context.Database.MigrateAsync();

            if (!context.Patients.Any())
            {
                var patients = new List<Patient>
                {
                    new Patient
                    {
                        Name = "Иван",
                        Surname = "Иванов",
                        Patronymic = "Иванович",
                        BirthDate = new DateOnly(1985, 5, 14),
                        Address = "г. Москва, ул. Ленина, д. 10, кв. 5",
                        PhoneNumber = "+79991112233",
                        MedicalPolicyNumber = "1234567890123456"
                    },
                    new Patient
                    {
                        Name = "Анна",
                        Surname = "Смирнова",
                        Patronymic = "Сергеевна",
                        BirthDate = new DateOnly(1992, 11, 23),
                        Address = "г. Москва, пр. Мира, д. 45, кв. 12",
                        PhoneNumber = "+79994445566",
                        MedicalPolicyNumber = "6543210987654321"
                    }
                };

                await context.Patients.AddRangeAsync(patients);
            }

            if (!context.Doctors.Any())
            {
                var doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        Name = "Алексей",
                        Surname = "Соколов",
                        Patronymic = "Петрович",
                        BirthDate = new DateOnly(1978, 3, 12),
                        Speciality = "Терапевт",
                        Position = "Заведующий отделением",
                        EmploymentDate = new DateOnly(2010, 9, 1)
                    },
                    new Doctor
                    {
                        Name = "Елена",
                        Surname = "Морозова",
                        Patronymic = "Викторовна",
                        BirthDate = new DateOnly(1988, 7, 25),
                        Speciality = "Кардиолог",
                        Position = "Врач-специалист",
                        EmploymentDate = new DateOnly(2015, 4, 15)
                    },
                    new Doctor
                    {
                        Name = "Дмитрий",
                        Surname = "Волков",
                        Patronymic = null,
                        BirthDate = new DateOnly(1990, 1, 30),
                        Speciality = "Терапевт",
                        Position = "Участковый врач",
                        EmploymentDate = new DateOnly(2018, 8, 20)
                    }
                };

                await context.Doctors.AddRangeAsync(doctors);
            }

            if (!context.Diseases.Any())
            {
                var diseases = new List<Disease>
                {
                    new Disease
                    {
                        Name = "Острая респираторная вирусная инфекция (ОРВИ)",
                        IcdCode = "J06.9",
                        Symptoms = "Повышенная температура, насморк, боль в горле, слабость",
                        Treatments = "Постельный режим, обильное питье, противовирусные препараты"
                    },
                    new Disease
                    {
                        Name = "Эссенциальная (первичная) гипертензия",
                        IcdCode = "I10",
                        Symptoms = "Головная боль, головокружение, повышенное артериальное давление",
                        Treatments = "Гипотензивная терапия, коррекция диеты, снижение потребления соли"
                    }
                };

                await context.Diseases.AddRangeAsync(diseases);
            }

            await context.SaveChangesAsync();
        }
    }
}