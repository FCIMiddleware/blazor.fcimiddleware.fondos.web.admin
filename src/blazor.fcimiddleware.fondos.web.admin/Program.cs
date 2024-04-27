using blazor.fcimiddleware.fondos.web.admin;
using blazor.fcimiddleware.fondos.web.admin.Services.Monedas;
using blazor.fcimiddleware.fondos.web.admin.Services.Paises;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//settings


// register services
builder.Services.AddScoped<IMonedaProxy, MonedaProxy>();
builder.Services.AddScoped<IPaisProxy, PaisProxy>();


//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5000/") });

await builder.Build().RunAsync();
