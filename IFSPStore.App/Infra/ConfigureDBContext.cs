using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using IFStore.Domain.Base;
using IFStore.Domain.Entities;
using IFStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace IFSPStore.App.Infra
{
    public static class ConfigureDBContext
    {
        public static ServiceCollection Services;

        public static  ServiceProvider ServicesProvider;


        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            
            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();


            Services.AddScoped<CadastroUsuarios, CadastroUsuarios>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
                {
                    config.CreateMap<Usuario, Usuario>();
                    config.CreateMap<Cidade, Cidade>();
                    config.CreateMap<Cliente, Cliente>();
                    config.CreateMap<Grupo, Grupo>();
                    config.CreateMap<Produto, Produto>();
                    config.CreateMap<Venda, Venda>();
                    config.CreateMap<VendaItem, VendaItem>();

                }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
