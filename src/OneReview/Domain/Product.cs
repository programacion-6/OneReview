﻿namespace OneReview.Domain;

public class Product : IEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public required string Name { get; init; }

    public required string Description { get; init; }

    public required string Category { get; init; }

    public required string SubCategory { get; init; }
}
