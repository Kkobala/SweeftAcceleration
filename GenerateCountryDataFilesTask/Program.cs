using GenerateCountryDataFilesTask.DTO;
using Newtonsoft.Json;

internal class Program
{
    public static async Task Main(string[] args)
    {
        await GenerateCountryDataFiles();
        await Console.Out.WriteLineAsync("Done");
    }

    private static async Task GenerateCountryDataFiles()
    {
        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://restcountries.com/v3.1/all");
        var content = await response.Content.ReadAsStringAsync();
        var countries = JsonConvert.DeserializeObject<CountryDto[]>(content);
        response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            foreach (var country in countries)
            {
                var fileName = $"{country.Name.Common}.txt";
                var text = $"Region: {country.Region}\nSubregion: {country.SubRegion}\nLatlng: {string.Join(",", country.LatLng)}\nArea: {country.Area}\nPopulation: {country.Population}";
                File.WriteAllText(fileName, text);
            }
        }
    }
}