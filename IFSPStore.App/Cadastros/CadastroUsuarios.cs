using IFSPStore.App.Base;
using IFSPStore.Service.Validators;
using IFStore.Domain.Base;
using IFStore.Domain.Entities;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroUsuarios : CadastroBase
    {
        private IBaseService<Usuario> _usuarioService;

        public CadastroUsuarios(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Login = txtLogin.Text,
                    Senha = txtSenha.Text,
                    Ativo = true
                };

                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaConsulta();
        }

        private void CarregaConsulta()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            dataGridViewConsulta.DataSource = usuarios;
        }
    }
}
