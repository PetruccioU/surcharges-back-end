using Domain.Common;

namespace Domain.Entities;
public class PlaceEntity: BaseEntity
{
    public string? PlaceName { get; set; }
    
    public string? PlaceDescription { get; set; }
    
    public string? PlaceImage { get; set; }
    
    public required string PlaceApiId { get; set; }
    
    public PlaceEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    } 
}