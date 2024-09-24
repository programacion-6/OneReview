namespace OneReview.Persistence.Repositories;

using System.Data;
using Dapper;
using OneReview.Domain;
using OneReview.Persistence.Database;

using Throw;

public class ProductsRepository(IDbConnectionFactory dbConnectionFactory)
{
    private readonly IDbConnectionFactory _dbConnectionFactory = dbConnectionFactory;

    public async Task<Product> CreateAsync(Product product)
    {
        // get db connection
        using IDbConnection connection = await _dbConnectionFactory.CreateConnectionAsync();
        // query
        var query = @"
            INSERT INTO products(id, name, description, category, sub_category)
            VALUES (@Id, @Name, @Description, @Category, @SubCategory)";
        // execute query
        var result = await connection.ExecuteAsync(query, product);

        result.Throw().IfNegativeOrZero();

        return await GetByIdAsync(product.Id);
    }

    public async Task<Product> GetByIdAsync(Guid productId)
    {
        // get db connection
        using IDbConnection connection = await _dbConnectionFactory.CreateConnectionAsync();
        // query
        var query = @"
            SELECT id, name, description, category, sub_category AS SubCategory
            FROM products
            WHERE id = @Id";
        // execute query
        return await connection.QueryFirstOrDefaultAsync<Product>(query, new { Id = productId });
    }
}
