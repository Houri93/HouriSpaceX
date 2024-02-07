using HouriSpaceX.ApiClient;
using HouriSpaceX.Server.Components;
using HouriSpaceX.Server.Services;

using MudBlazor.Services;

using SpaceXData.ApiClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<SpaceXDataApiClient>();
builder.Services.AddScoped<HouriSpaceXApiClient>();

builder.Services.AddScoped<CapsulesService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<CoresService>();
builder.Services.AddScoped<CrewService>();


builder.Services.AddSingleton<CapsuleMapper>();
builder.Services.AddSingleton<CompanyMapper>();
builder.Services.AddSingleton<CompanyLinksMapper>();
builder.Services.AddSingleton<HeadquartersMapper>();
builder.Services.AddSingleton<CoresMapper>();
builder.Services.AddSingleton<CrewMapper>();

builder.Services.AddMudServices();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(HouriSpaceX.Client._Imports).Assembly);

app.Run();
