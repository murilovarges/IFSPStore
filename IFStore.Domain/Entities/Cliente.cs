using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {
            
        }

        public Cliente(int id, string? nome, string? endereco, string? bairro, Cidade? cidade) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
