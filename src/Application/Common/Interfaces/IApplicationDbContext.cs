using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<SurchargeEntity> SurchargeEntity { get; }
    
    DbSet<SurchargeListEntity> SurchargeListEntity { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}