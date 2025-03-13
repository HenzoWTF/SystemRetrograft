using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SystemaRetrograft;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<NotificationService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.apir.somee.com/") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7279") });

await builder.Build().RunAsync();