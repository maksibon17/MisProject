namespace MisProject.ApiService.Diseases
{
    public interface IDiseaseService
    {
        Task<IEnumerable<DiseaseDTO>> GetAllDiseasesAsync();
    }
}
