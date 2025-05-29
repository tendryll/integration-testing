# Integration Testing project

## ... some notes

```csharp
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
```

A GET request
```csharp
static async Task GetExample()
{
    using var client = new HttpClient();
    var response = await client.GetAsync("https://api.example.com/items");
    
    if (response.IsSuccessStatusCode)
    {
        string result = await response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}
```

A POST request with a JSON payload
```csharp
static async Task PostExample()
{
    using var client = new HttpClient();
    var json = "{\"name\":\"Widget\",\"price\":9.99}";
    var content = new StringContent(json, Encoding.UTF8, "application/json");

    var response = await client.PostAsync("https://api.example.com/items", content);

    if (response.IsSuccessStatusCode)
    {
        string result = await response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}
```

A PUT request
```csharp
static async Task PutExample()
{
    using var client = new HttpClient();
    var json = "{\"id\":1,\"name\":\"Updated Widget\"}";
    var content = new StringContent(json, Encoding.UTF8, "application/json");

    var response = await client.PutAsync("https://api.example.com/items/1", content);

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Update successful.");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}
```

A DELETE request
```csharp
static async Task DeleteExample()
{
    using var client = new HttpClient();
    var response = await client.DeleteAsync("https://api.example.com/items/1");

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Delete successful.");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}
```