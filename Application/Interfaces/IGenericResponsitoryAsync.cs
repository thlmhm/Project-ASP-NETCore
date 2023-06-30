using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericResponsitoryAsync<TEntity> where TEntity: class 
    {
        Task<TEntity> GetByIdAsync(object id);
        
        Task<IReadOnlyList<TEntity>> GetAllAsync();

        Task<IReadOnlyList<TEntity>> GetPagedResponseAsync(int pageNumber, int pageSize);
        Task<TEntity> AddAsync(TEntity entity);
        Task<long> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<long> UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task<long> DeleteAsync(TEntity entity);
        Task<long> DeleteRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> GetSingleByConditionAsync(Expression<Func<TEntity, bool>> expression);
        Task<IReadOnlyList<TEntity>> GetMultyByCondition(Expression<Func<TEntity, bool>> expression);
        Task<bool> CheckExistsByCondition(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetDataAsQueryable();

    }
}
