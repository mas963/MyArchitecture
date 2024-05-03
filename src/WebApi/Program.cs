using Klinik.Infrastructure;
using Klinik.Infrastructure.Data;
using Klinik.Infrastructure.Identity;
using Klinik.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Hosting;
using Randevu.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebApiServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.InitialiseDatabaseAsync();
}
else
{
    app.UseHsts();
}

app.UseHealthChecks("/health");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapGroup("/auth").MapIdentityApi<ApplicationUser>();
app.MapControllers();
app.UseExceptionHandler(options => { });

app.Run();