using KolosAPBD.Repositories;
using KolosAPBD.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<DoctorService>();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();