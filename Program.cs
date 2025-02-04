using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SystemaRetrograft;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<NotificationService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.apir.somee.com/") });

await builder.Build().RunAsync();