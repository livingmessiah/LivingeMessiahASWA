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

var host = builder.Build(); // To add Logger, I need the `host` variable

var logger = host.Services.GetRequiredService<ILoggerFactory>().CreateLogger<Program>();
builder.Logging.SetMinimumLevel(LogLevel.Warning);

logger.LogWarning("Inside {project}!{class}, right before host.RunAsync(); API_Prefix: {apiPrefix}"
, nameof(Client), nameof(Program), (string?)(builder.Configuration["API_Prefix"] ?? "???"));

await host.RunAsync(); //was: await builder.Build().RunAsync();