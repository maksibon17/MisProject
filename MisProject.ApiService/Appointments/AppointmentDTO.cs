using MisProject.ApiService.Appointments;
using MisProject.ApiService.Diseases;
using MisProject.ApiService.Doctors;
using MisProject.ApiService.Patients;

public record AppointmentDTO(
    DateTimeOffset DateTime,
    AppointmentStatus Status,
    string Complaint,
    PatientDTO Patient,
    DoctorDTO Doctor,
    DiseaseDTO? Disease
);