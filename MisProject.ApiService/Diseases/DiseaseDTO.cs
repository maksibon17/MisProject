namespace MisProject.ApiService.Diseases
{
    public record DiseaseDTO(
         string Name,
         string IcdCode, //международный код болезни
         string Symptoms,
         string Treatments
    );
   
}
