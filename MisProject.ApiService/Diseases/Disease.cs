namespace MisProject.ApiService.Diseases
{
    public class Disease
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string IcdCode { get; set; } //международный код болезни
        public string Symptoms { get; set; }
        public string Treatments { get; set; }
    }
}
