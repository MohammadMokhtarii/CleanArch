using CleanArch.Application;
using CleanArch.Infrastructure.Persistence;
using CleanArch.Infrastructure.External;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicatioinServices()
                .AddApplicationExternalServices()
                .AddPersistenceServices(builder.Configuration);

#endregion
#region Application
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion

