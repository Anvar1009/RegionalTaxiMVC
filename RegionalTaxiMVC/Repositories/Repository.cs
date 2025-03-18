using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Linq.Expressions;
using System.Linq;
using RegionalTaxiMVC.Repositories.Interfaces;

namespace RegionalTaxiMVC.Repositories
{
    public abstract class Repository<T, TId>(DbContext context) : IRepository<T, TId> where T : class, IEntity<TId>
    {
        protected DbContext Context { get; } = context;


        public IQueryable<T> GetAll(Expression<Func<T, bool>>? predicate = null, bool tracked = true,
            bool ignoreQueryFilters = false)
        {
            IQueryable<T> query = Context.Set<T>();

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            if (ignoreQueryFilters)
            {
                query = query.IgnoreQueryFilters();
            }

            return query;
        }

        public async Task<T?> GetById(TId id,
            bool tracked = true,
            bool ignoreQueryFilters = false,
            CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(id);

            var query = GetAll(x => x.Id.Equals(id), tracked, ignoreQueryFilters);

            return await query.FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<T?> GetFirstMatch(Expression<Func<T, bool>> predicate,
            bool tracked = true,
            bool ignoreQueryFilters = false,
            CancellationToken cancellationToken = default)
        {
            var query = GetAll(predicate, tracked, ignoreQueryFilters);

            return await query.FirstOrDefaultAsync(cancellationToken);
        }

        public async Task Add(T entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            await Context.AddAsync(entity, cancellationToken);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task AddRange(IEnumerable<T> entities, bool saveChanges = true,
            CancellationToken cancellationToken = default)
        {
            await Context.AddRangeAsync(entities, cancellationToken);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task Update(T entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            Context.Update(entity);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task UpdateRange(IEnumerable<T> entities, bool saveChanges = true,
            CancellationToken cancellationToken = default)
        {
            Context.UpdateRange(entities);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task Remove(T entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            Context.Remove(entity);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task RemoveRange(IEnumerable<T> entity, bool saveChanges = true,
            CancellationToken cancellationToken = default)
        {
            Context.RemoveRange(entity);

            if (saveChanges)
            {
                await SaveChanges(cancellationToken);
            }
        }

        public async Task SaveChanges(CancellationToken cancellationToken = default)
        {
            await Context.SaveChangesAsync(cancellationToken);
        }
    }
}
