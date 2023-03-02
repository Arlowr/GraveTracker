using GraveTracker.Areas.Frostgrave.Models;
using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GraveTrackerDbContextConnection") ?? throw new InvalidOperationException("Connection string 'GraveTrackerDbContextConnection' not found.");

builder.Services.AddScoped<ISoldierRepository, SoldierRepository>();
builder.Services.AddScoped<IFGCharacterSuperTypeRepository, FGCharacterSuperTypeRepository>();
builder.Services.AddScoped<IFGCharacterTypeRepository, FGCharacterTypeRepository>();
builder.Services.AddScoped<IFGInjuryRepository, FGInjuryRepository>();
builder.Services.AddScoped<IFGWeaponRepository, FGWeaponRepository>();
builder.Services.AddScoped<IFGArmourRepository, FGArmourRepository>();
builder.Services.AddScoped<IFGItemRepository, FGItemRepository>();
builder.Services.AddScoped<IHomebaseRepository, HomebaseRepository>();
builder.Services.AddScoped<IHomebaseTypeRepository, HomebaseTypeRepository>();
builder.Services.AddScoped<ISpellRepository, SpellRepository>();
builder.Services.AddScoped<ISpellSchoolRepository, SpellSchoolRepository>();
builder.Services.AddScoped<IWarbandRepository, WarbandRepository>();
builder.Services.AddScoped<IWizardRepository, WizardRepository>();
builder.Services.AddScoped<IApprenticeRepository, ApprenticeRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GraveTrackerDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "AreaFrostgrave",
    areaName: "Frostgrave",
    pattern: "Frostgrave/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

DbInitializer.Seed(app);
app.Run();
