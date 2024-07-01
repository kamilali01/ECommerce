using TapAz.DAL.Entities.Common;

namespace TapAz.DAL.Repositories.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        List<TEntity> Get();
        TEntity Get(int id);
        public void Add(TEntity entity);
    }
}
