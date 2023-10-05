using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace IFSPStore.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"IFSP Store", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        #endregion

        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                materialTabControl.SelectedIndex = 0;
                materialTabControl.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        #endregion
    }

}
