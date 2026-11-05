using MisProject.ApiService.Diseases;
using MisProject.ApiService.Doctors;
using MisProject.ApiService.Patients;

namespace MisProject.ApiService.Appointments
{
    public class Appointment
    {
        public long Id { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public AppointmentStatus Status { get; set; }
        public string Complaint { get; set; }
        public long PatientId { get; set; }
        public Patient Patient { get; set; }
        public long DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public long? DiseaseId { get; set; }
        public Disease Disease { get; set; }
    }
}
