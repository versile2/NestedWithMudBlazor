
using MudBlazor.Extensions;
using MudExtensions.Services;
using NestedWithMudBlazor.DAL.Interfaces;
using NestedWithMudBlazor.DAL.Repositories;
using NestedWithMudBlazor.DAL.Services;
using NestedWithMudBlazor.UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudExtensions();

builder.Services.AddMudServicesWithExtensions(config =>
{
    config.SnackbarConfiguration.PositionClass = MudBlazor.Defaults.Classes.Position.TopRight;
    config.SnackbarConfiguration.VisibleStateDuration = 5000; // show toasts for 5 seconds by defauult
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.HideTransitionDuration = 0;
});

builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<INavigationRepository, NavigationRepository>();
builder.Services.AddScoped<ExerciseRepository, ExerciseRepository>();

var app = builder.Build();

app.UseMudExtensions();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
