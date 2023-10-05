using IFStore.Domain.Base;

namespace IFSPStore.Domain.Base
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(object id);

        IList<TEntity> Select();

        TEntity Select(object id);
    }
}