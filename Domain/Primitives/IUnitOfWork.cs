namespace Domain.Primitives;

public interface IUnitofWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}