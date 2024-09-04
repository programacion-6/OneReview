namespace OneReview.Persistence.Database;

using System.Reflection;
using DbUp;

public static class DbInitializer
{
    public static void Initialize(string connectionString)
    {
        // ensure the postgres database exists
        EnsureDatabase.For.PostgresqlDatabase(connectionString);
        // get hold of all the sql scripts
        var upgrader = DeployChanges.To
            .PostgresqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .WithTransaction()
            .LogToConsole()
            .Build();
        // run the migrations
        var result = upgrader.PerformUpgrade();

        if (!result.Successful)
        {
            throw new InvalidOperationException("Failed migration");
        }
    }
}
