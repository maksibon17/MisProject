using Microsoft.AspNetCore.Mvc;

namespace MisProject.ApiService.Patients
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service) {
            _service = service; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            var patients = await _service.GetAllPatientsAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDTO>> GetPatient(long id)
        {
            var patient = await _service.GetPatientByIdAsync(id);
            if (patient != null)
            {
                return Ok(patient);
            }
            return NotFound();
        }


    }
}
