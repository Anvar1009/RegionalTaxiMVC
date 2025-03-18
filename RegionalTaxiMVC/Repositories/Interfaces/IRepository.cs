using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Common;
using System.Linq.Expressions;

namespace RegionalTaxiMVC.Repositories.Interfaces
{
    public interface IRepository<T, TId> where T : class, IEntity<TId>
    {

        IQueryable<T> GetAll(Expression<Func<T, bool>>? predicate = null,
            bool tracked = true,
            bool ignoreQueryFilters = false);

        Task<T?> GetById(TId id,
            bool tracked = true,
            bool ignoreQueryFilters = false,
            CancellationToken cancellationToken = default);

        Task<T?> GetFirstMatch(Expression<Func<T, bool>> predicate,
            bool tracked = true,
            bool ignoreQueryFilters = false,
            CancellationToken cancellationToken = default);

        Task Add(T entity,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task AddRange(IEnumerable<T> entities,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task Update(T entity,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task UpdateRange(IEnumerable<T> entities,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task Remove(T entity,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task RemoveRange(IEnumerable<T> entity,
            bool saveChanges = true,
            CancellationToken cancellationToken = default);

        Task SaveChanges(CancellationToken cancellationToken = default);
    }
}
