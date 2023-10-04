using IFStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Preco);

            builder.Property(prop => prop.Quantidade);

            builder.Property(prop => prop.DataCompra);

            builder.Property(prop => prop.UnidadeVenda)
                .HasColumnType("varchar(10)");

            builder.HasOne<Grupo>(prop => prop.Grupo);
        }
    }
}
