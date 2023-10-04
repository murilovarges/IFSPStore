using System.Text.Json;
using IFStore.Domain.Entities;

namespace IFSPStrore.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            var cidade = new Cidade
            {
                Nome = "Batatais",
                Estado = "SP"
            };

            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Batatais");
            Assert.AreEqual(cidade.Estado, "SP");

        }
        [TestMethod]
        public void TestCliente() 
        {
            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Giovanna");
            Assert.AreEqual(cliente.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(cliente.Bairro, "Centro");
            Assert.AreEqual(cliente.Endereco, "Rua Teste");

        }
        [TestMethod]
        public void TesteGrupo ()
        {
            var grupo = new Grupo();
            grupo.Nome = "Alimentos";

            Console.WriteLine(JsonSerializer.Serialize(grupo));
            Assert.AreEqual(grupo.Nome, "Alimentos");

        }
        [TestMethod]
        public void TesteProduto ()
        {
            var produto = new Produto();
            var grupo = new Grupo();

            grupo.Nome = "Alimentos";

            produto.Nome = "Arroz";
            produto.UnidadeVenda = "BRI";
            produto.Quantidade = 2;
            produto.Grupo = grupo;

            Console.WriteLine(JsonSerializer.Serialize(produto));
            Assert.AreEqual(produto.Nome, "Arroz");
            Assert.AreEqual(produto.UnidadeVenda, "BRI");
            Assert.AreEqual(produto.Quantidade, 2);
            Assert.AreEqual(produto.Grupo, grupo);

        }
        [TestMethod]
        public void TesteUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = "teste@gmail.com";
            usuario.Senha = "teste";
            usuario.Login = "teste";
            usuario.DataCadastro = DateTime.Today;
            usuario.Ativo = true;

            Assert.AreEqual(usuario.Email, "teste@gmail.com");
            Assert.AreEqual(usuario.Senha, "teste");
            Assert.AreEqual(usuario.Login, "teste");
            Assert.AreEqual(usuario.DataCadastro, DateTime.Today);
            Assert.AreEqual(usuario.Ativo, true);
        }

        [TestMethod]
        public void TesteVendas ()
        {
            var venda = new Venda();
            var vendaItem = new VendaItem();

            var produto = new Produto();
            var grupo = new Grupo();

            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            grupo.Nome = "Alimentos";

            produto.Nome = "Arroz";
            produto.UnidadeVenda = "BRI";
            produto.Quantidade = 2;
            produto.Grupo = grupo;

            venda.Cliente = cliente;
            venda.Data = DateTime.Today;

            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.Cliente, cliente);
            Assert.AreEqual(venda.Data, DateTime.Today);


            vendaItem.Quantidade = 2;
            vendaItem.Produto = produto;
            vendaItem.ValorUnitario = 5;
            vendaItem.Venda = venda;

            Console.WriteLine(JsonSerializer.Serialize(vendaItem));
            Assert.AreEqual(vendaItem.Quantidade, 2);
            Assert.AreEqual(vendaItem.Produto, produto);
            Assert.AreEqual(vendaItem.ValorUnitario, 5);
            Assert.AreEqual(vendaItem.Venda, venda);

            venda.Items.Add(vendaItem);


            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.Items[0].ValorUnitario, vendaItem.ValorUnitario);

        }

    }
}