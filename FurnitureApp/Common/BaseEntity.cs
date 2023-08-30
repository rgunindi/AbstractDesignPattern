namespace FurnitureApp.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? UpdateDate { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;
}