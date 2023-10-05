using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Service.Validators;
using IFStore.Domain.Base;
using IFStore.Domain.Entities;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroUsuarios : CadastroBase
    {
        private readonly IBaseService<Usuario> _usuarioService;

        private List<Usuario>? usuarios;

        public CadastroUsuarios(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Ativo = chkAtivo.Checked;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

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
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();
            dataGridViewConsulta.DataSource = usuarios;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            chkAtivo.Checked = (bool)(linha?.Cells["Ativo"].Value ?? false);

            txtDataCadastro.Text = DateTime.TryParse(linha?.Cells["DataCadastro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            txtDataLogin.Text = DateTime.TryParse(linha?.Cells["DataLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }

    }
}
