using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFremework;
using DataAccessLayer.Contexts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IServicesService, ServicesManager>();
builder.Services.AddScoped<IServicesDal, EntityFrameworkServicesDal>();
builder.Services.AddScoped<ITeamsService, TeamsManager>();
builder.Services.AddScoped<ITeamsDal, EntityFrameworkTeamsDal>();
builder.Services.AddScoped<IAnnouncementsService, AnnouncementManager>();
builder.Services.AddScoped<IAnnouncementsDal, EntityFrameworkAnnounCementDal>();
builder.Services.AddScoped<IImagesService, ImagesManager>();
builder.Services.AddScoped<IImagesDal, EntityFrameworkImagesDal>();
builder.Services.AddScoped<IAddressService, AddressManager>();
builder.Services.AddScoped<IAddressDal, EntityFrameworkAddressDal>();
builder.Services.AddScoped<IContactsService, ContactManager>();
builder.Services.AddScoped<IContactsDal, EntityFrameworkContactDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EntityFrameworkSocialMediaDal>();

builder.Services.AddScoped<IAdminService, AdminManager >();
builder.Services.AddScoped<IAdminDal, EntityFrameworkAdminDal>();

builder.Services.AddDbContext<AgricultureContext>();

builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
