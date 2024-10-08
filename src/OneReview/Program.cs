using OneReview.DependencyInjection;
using OneReview.RequestPipeline;

var builder = WebApplication.CreateBuilder(args);
{
    if (builder.Environment.IsDevelopment())
    {
        Console.WriteLine("---------DEVELOPMENT MODE---------");
    }
    // configure services (DI)
    builder.Services
        .AddGlobalErrorHandling()
        .AddServices()
        .AddPersistance(builder.Configuration)
        .AddControllers();
}

var app = builder.Build();
{
    // configure request pipeline
    app.UseGlobalErrorHandling();
    app.MapControllers();
    app.InitializeDatabase();
}

app.Run();