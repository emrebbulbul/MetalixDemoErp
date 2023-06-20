using BusinessLayer.Operations.Implementations;
using BusinessLayer.Operations.Interfaces;
using DataAccessLayer.Repositories.Implementations;
using DataAccessLayer.Repositories.Interfaces;
using MetalixDemoErp.Controllers;
using MetalixDemoErp.DataAccessLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//                    .RequireAuthenticatedUser()
//                    .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//});
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IDangilNoRepository, DangilNoRepository>();
builder.Services.AddScoped<ICompanyOperations, CompanyOperations>();
builder.Services.AddScoped<IDangilNoOperations, DangilNoOperations>();
builder.Services.AddMvc();
//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
//    {
//        x.LoginPath = "/Company/Index";
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Company}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Company}/{action=Index}/{id?}");
});

app.Run();

//builder.Services.AddScoped<CompanyController>();
