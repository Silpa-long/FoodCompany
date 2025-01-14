using System.Linq.Expressions;

namespace FoodCompany.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllExpression(Expression<Func<T, bool>> filter = null, string? incluseProperties = null);
        T Get(Expression<Func<T, bool>> filter = null, string? incluseProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);


    }

}
