namespace GenerateCountryDataFilesTask.DTO
{
    public class CountryDto
    {
        public NameDto Name { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public double[] LatLng { get; set; }
        public double Area { get; set; }
        public long Population { get; set; }
    }
}
