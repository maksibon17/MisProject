using Microsoft.AspNetCore.Mvc;

namespace MisProject.ApiService.Diseases
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseasesController : ControllerBase
    {
        private readonly IDiseaseService _service;

        public DiseasesController(IDiseaseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiseaseDTO>>> GetDiseases()
        {
            var diseases = await _service.GetAllDiseasesAsync();
            return Ok(diseases);
        }
    }
}