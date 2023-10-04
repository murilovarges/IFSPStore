using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using IFStore.Domain.Base;
using IFStore.Domain.Entities;
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
            var cad = ConfigureDBContext.ServicesProvider.GetService<CadastroUsuarios>();
            if (cad != null)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}