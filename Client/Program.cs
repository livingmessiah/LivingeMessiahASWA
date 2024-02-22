using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Blazored.LocalStorage;
using Blazored.Toast;
using Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredToast();
builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(builder.Configuration["API_Prefix"] 
		?? builder.HostEnvironment.BaseAddress)
});

/*
 builder.Services.AddSingleton<StateContainer>();
 - gotten from repos\the-urlist\BlazorSWA\Client\Program.cs
*/


builder.Services.AddScoped<ProfileService>();
/*
 builder.Services.AddSingleton<StateContainer>();
 - gotten from repos\the-urlist\BlazorSWA\Client\Program.cs
 - I'm guessing eventually I'll use `AppState.cs` (Client/State/)
*/


builder.Services.AddBlazoredLocalStorageAsSingleton();
/*
 - gotten from samples/BlazorWebAssembly.Project.cs 
 - was builder.Services.AddBlazoredLocalStorage();
*/

var host = builder.Build(); // Added Logger which means I need the `host` variable
var logger = host.Services.GetRequiredService<ILoggerFactory>().CreateLogger<Program>();
builder.Logging.SetMinimumLevel(LogLevel.Warning);
logger.LogWarning("Inside Client!Program, right before host.RunAsync()");
await host.RunAsync(); //await builder.Build().RunAsync();