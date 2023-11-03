using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using ReaLTaiizor.Forms;

namespace IFSPStore.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
#if DEBUG
            txtLogin.Text = @"admin";
            txtSenha.Text = @"admin";
#endif
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(txtLogin.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
            else if (!usuario.Ativo)
            {
                MessageBox.Show("Usuário inativo!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
            else
            {
                usuario.DataLogin = DateTime.Now;
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuariosCadastrados();

            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Login == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuariosCadastrados()
        {
            var usuarios = _usuarioService.Get<UsuarioModel>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    DataCadastro = DateTime.Now,
                    Ativo = true,
                    Nome = "Administrador",
                    Login = "admin",
                    Senha = "admin",
                    Email = "admin@mail.com"
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
