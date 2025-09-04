namespace ACME.OOP.SCM.Domain.Model.ValueObjects;
/// <summary>
/// Value Object representing a Supplier Identifier in the Supply Chain Management.
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }
    /// <summary>
    /// Creates a new instance of the <see cref="SupplierId"/> Value Object.
    /// </summary>
    /// <param name="identifier">The unique identifier for the supplier.</param>
    /// <exception cref="ArgumentException">Thrown when the identifier is null or whitespace.</exception>
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier id cannot be null or whitespace.", nameof(identifier));
        Identifier = identifier;
    }
}