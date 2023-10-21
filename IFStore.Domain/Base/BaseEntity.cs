namespace IFSPStore.Domain.Base
{
    public abstract class BaseEntity<IId> : IBaseEntity
    {
        protected BaseEntity()
        {
            
        }

        protected BaseEntity(IId id)
        {
            Id = id;
        }

        public IId? Id { get; set; }
    }
}
