using BlazorAppWasmefsqlite;
using BlazorAppWasmefsqlite.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using SqliteWasmHelper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSqliteWasmDbContextFactory<TaskDBContext>(opt =>
opt.UseSqlite("Data Source=mytaskdb.sqlite3"));
await builder.Build().RunAsync();
