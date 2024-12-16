using Newtonsoft.Json;

namespace Task2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var task = await FetchData("https://catfact.ninja/fact");
            Console.WriteLine(task?.Fact);
            Console.ReadLine();
        }

        public static async Task<CatFact?> FetchData(string apiUrl)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(apiUrl);
            var catFact = JsonConvert.DeserializeObject<CatFact>(response);
            return catFact;
        }
    }
}
