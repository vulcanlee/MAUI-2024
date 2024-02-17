namespace MA15;

public class AddingCalculatorService
{
    public async Task<string> AddAsync(int a, int b)
    {
        int estimate = 5000;
        string url = $"https://businessblazor.azurewebsites.net/api/RemoteService/" +
            $"Add/{a}/{b}/{estimate}";

        HttpClient client = new HttpClient();

        string result = await client.GetStringAsync(url);
        return result;
    }
}
