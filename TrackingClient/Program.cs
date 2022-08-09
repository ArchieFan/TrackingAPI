using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using TrackingClient;

HttpClient client = new();
client.BaseAddress = new Uri("https://localhost:7257");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json")
    );
HttpResponseMessage response = await client.GetAsync("api/issues");
response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    var issues = await response.Content.ReadFromJsonAsync<IEnumerable<IssueDto>>();
    foreach (var issue in issues)
    {
        Console.WriteLine(issue.Title);
        Console.WriteLine(issue.Description);
        Console.WriteLine(issue.Completed);
    }
} else
{
    Console.WriteLine("No Result");
}

Console.ReadLine();