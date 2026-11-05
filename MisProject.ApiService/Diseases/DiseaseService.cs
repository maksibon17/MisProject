using Microsoft.EntityFrameworkCore;
using MisProject.ApiService.Data;

namespace MisProject.ApiService.Diseases
{
    public class DiseaseService : IDiseaseService
    {
        private readonly ApplicationDbContext _context;

        public DiseaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DiseaseDTO>> GetAllDiseasesAsync()
        {
            return await _context.Diseases
                .Select(disease => new DiseaseDTO(
                    disease.Name,
                    disease.IcdCode,
                    disease.Symptoms,
                    disease.Treatments
                ))
                .ToListAsync();
        }
    }
}