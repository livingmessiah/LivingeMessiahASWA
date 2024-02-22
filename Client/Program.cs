using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Blazored.LocalStorage;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredToast();
builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(builder.Configuration["API_Prefix"] 
		?? builder.HostEnvironment.BaseAddress)
});

builder.Services.AddBlazoredLocalStorage();
//	builder.Services.AddSingleton<StateContainer>(); // gotten from repos\the-urlist\BlazorSWA\Client\Program.cs

await builder.Build().RunAsync();
