using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace IFSPStore.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
            
        }

        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Grupo>? Grupo { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<Venda>? Venda { get; set; }
        public DbSet<VendaItem>? VendaItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);            
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
            modelBuilder.Entity<VendaItem>(new VendaItemMap().Configure);
        }
    }
}
