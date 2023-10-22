using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroVenda : CadastroBase
    {
        private readonly IBaseService<Venda> _vendaService;

        private List<Venda>? vendas;

        public CadastroVenda(IBaseService<Venda> vendaService)
        {
            _vendaService = vendaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Venda venda)
        {
            //venda.Nome = txtNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var venda = _vendaService.GetById<Venda>(id);
                        PreencheObjeto(venda);
                        venda = _vendaService.Update<Venda, Venda, VendaValidator>(venda);
                    }
                }
                else
                {
                    var venda = new Venda();
                    PreencheObjeto(venda);
                    _vendaService.Add<Venda, Venda, VendaValidator>(venda);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _vendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            vendas = _vendaService.Get<Venda>().ToList();
            dataGridViewConsulta.DataSource = vendas;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            //txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

        private void txtVlUnitario_Click(object sender, EventArgs e)
        {

        }
    }
}
