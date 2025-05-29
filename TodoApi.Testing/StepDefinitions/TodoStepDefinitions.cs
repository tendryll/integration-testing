using Reqnroll;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Testing.StepDefinitions;

[Binding]
public sealed class TodoStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;

    public TodoStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given("the endpoint is {string}")]
    public void GivenTheEndpointIs(string endpoint)
    {
        _scenarioContext.Add("endpoint", endpoint);
    }
        
    [When("the endpoint is called")]
    public void WhenItemsAreRequested()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://api.example.com/items");
    }
        
    [Then("the result is:")]
    public void ThenTheResultIs(string multilineText)
    {
        _scenarioContext.Pending();
    }
}