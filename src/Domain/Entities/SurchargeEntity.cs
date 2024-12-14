using Domain.Common;
namespace Domain.Entities;

public class SurchargeEntity: BaseEntity
{
    public double SurchargePercentage { get; set; }
    
    public string? SurchargeDescription { get; set; }
    
    public string? SurchargePaymentMethod { get; set; }
    
    public string? SurchargeImage { get; set; }
    
    public required Guid PlaceId { get; set; }
    
    public SurchargeEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}
