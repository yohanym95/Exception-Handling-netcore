using ExceptionHandling.Middlewares;
using ExceptionHandling.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default",
        "{controller}/{action}/{id?}",
        new { controller = "App", action = "Index" });
});

app.Run();