using Microsoft.AspNetCore.Mvc;

namespace MisProject.ApiService.Doctors
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _service;

        public DoctorsController(IDoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDTO>>> GetDoctors(string? speciality)
        {
            var doctors = await _service.GetDoctorsAsync(speciality);
            return Ok(doctors);
        }
    }
}