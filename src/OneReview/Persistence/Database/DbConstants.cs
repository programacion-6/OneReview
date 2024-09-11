namespace OneReview.Persistence.Database;

public static class DbConstants
{
    public static readonly string Name = Environment.GetEnvironmentVariable("REST_DB_NAME"); 
    public static readonly string Address = Environment.GetEnvironmentVariable("REST_DB_ADDRESS");
    public static readonly string Port = Environment.GetEnvironmentVariable("REST_DB_PORT");

    public static string GetDefaultConnectionPath()
    {
        return $"{Name}{Address}{Port}";
    }
}
