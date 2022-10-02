using LeaveManagementSystem.UI.Services;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

var api = builder.Configuration.GetValue<string>("ApiUrl");
var syncKey = builder.Configuration.GetValue<string>("SyncKey");

builder.Services.AddSyncfusionBlazor();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<IAuthService, AuthService>(opts => { opts.BaseAddress = new Uri(api); });
builder.Services.AddHttpClient<IEmployeeLeaveInfoService, EmployeeLeaveInfoService>(opts => { opts.BaseAddress = new Uri(api); });

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncKey);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
