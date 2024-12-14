namespace Domain.Entities;

public class SurchargeListEntity: BaseEntity
{
    public string? Title { get; set; }

    public IList<SurchargeEntity> SurchargesList { get; private set; } = new List<SurchargeEntity>();
}