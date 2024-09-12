﻿namespace OneReview.Persistence.Database;

using System.Data;
using Npgsql;

public class NpgsqlConnectionFactory(string connectionString) : IDbConnectionFactory
{
    private readonly string _connectionString = connectionString;

    public async Task<IDbConnection> CreateConnectionAsync()
    {
        var connection = new NpgsqlConnection(_connectionString);

        await connection.OpenAsync();

        return connection;
    }
}
