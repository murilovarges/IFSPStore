using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigureDI.ServicesProvider == null) return;
            var cad = ConfigureDI.ServicesProvider.GetService<CadastroUsuario>();
            if (cad == null) return;
            cad.MdiParent = this;
            cad.Show();
        }

        private void grupoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigureDI.ServicesProvider == null) return;
            var cad = ConfigureDI.ServicesProvider.GetService<CadastroGrupo>();
            if (cad == null) return;
            cad.MdiParent = this;
            cad.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigureDI.ServicesProvider == null) return;
            var cad = ConfigureDI.ServicesProvider.GetService<CadastroProduto>();
            if (cad == null) return;
            cad.MdiParent = this;
            cad.Show();
        }
    }
}