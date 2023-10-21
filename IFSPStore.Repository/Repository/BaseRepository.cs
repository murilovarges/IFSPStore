using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlContext;

        public BaseRepository(MySqlContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public void ClearChangeTracker()
        {
            _mySqlContext.ChangeTracker.Clear();
        }
        public void AttachObject(object obj)
        {
            _mySqlContext.Attach(obj);
        }

        public void Insert(TEntity obj)
        {
            _mySqlContext.Entry(obj).State = EntityState.Added;
            _mySqlContext.Set<TEntity>().Add(obj);
            _mySqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _mySqlContext.Entry(obj).State = EntityState.Modified;
            _mySqlContext.SaveChanges();
        }

        public void Delete(object id)
        {
            _mySqlContext.Set<TEntity>().Remove(Select(id));
            _mySqlContext.SaveChanges();
        }

        public IList<TEntity> Select() => _mySqlContext.Set<TEntity>().ToList();

        public TEntity Select(object id) => _mySqlContext.Set<TEntity>().Find(id)!;
    }
}