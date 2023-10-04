using System.Text.Json;
using IFStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Grupo> Grupo{ get; set; }
            public DbSet<Produto> Produto { get; set; }
            public DbSet<Venda> Venda { get; set; }
            public DbSet<VendaItem> VendaItem { get; set; }

            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }
        
        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {

                var usuario = new Usuario
                {
                    Nome = "Murilo",
                    Email = "murilo@mail.com",
                    Senha = "123",
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now
                };
                context.Usuario.Add(usuario);
                
                usuario = new Usuario
                {
                    Nome = "João",
                    Email = "joao@mail.com",
                    Senha = "123",
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now
                };
                context.Usuario.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }
    }
}