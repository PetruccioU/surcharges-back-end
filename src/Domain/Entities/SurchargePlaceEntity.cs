using Domain.Common;
namespace Domain.Entities;

public class SurchargePlaceEntity: BaseEntity
{
    public double SurchargePercentage { get; set; }
    
    public string? SurchargeDescription { get; set; }
    
    public string? SurchargePaymentMethod { get; set; }
    
    public string? SurchargeImage { get; set; }
    
    public required Guid PlaceId { get; set; }
    
    public SurchargePlaceEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}
