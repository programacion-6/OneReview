using OneReview.DependencyInjection;
using OneReview.RequestPipeline;

var builder = WebApplication.CreateBuilder(args);
{
    // configure services (DI)
    builder.Services
        .AddServices()
        .AddControllers();
}

var app = builder.Build();
{
    // configure request pipeline
    app.MapControllers();
    app.InitializeDatabase();
}

app.Run();