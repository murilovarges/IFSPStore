namespace IFSPStore.App.Cadastros
{
    partial class CadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1 = new GroupBox();
            txtVlTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtVlUnitario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorTotalVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataVenda = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(730, 611);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtDataVenda);
            tabPageCadastro.Controls.Add(txtValorTotalVenda);
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(722, 576);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorTotalVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataVenda, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(504, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(107, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtVlTotal);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtVlUnitario);
            groupBox1.Controls.Add(cboProduto);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 238);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos da Venda";
            // 
            // txtVlTotal
            // 
            txtVlTotal.AnimateReadOnly = false;
            txtVlTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtVlTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtVlTotal.BackgroundImageLayout = ImageLayout.None;
            txtVlTotal.CharacterCasing = CharacterCasing.Normal;
            txtVlTotal.Depth = 0;
            txtVlTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVlTotal.HideSelection = true;
            txtVlTotal.Hint = "Valor Total";
            txtVlTotal.LeadingIcon = null;
            txtVlTotal.Location = new Point(467, 22);
            txtVlTotal.MaxLength = 32767;
            txtVlTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVlTotal.Name = "txtVlTotal";
            txtVlTotal.PasswordChar = '\0';
            txtVlTotal.PrefixSuffixText = null;
            txtVlTotal.ReadOnly = true;
            txtVlTotal.RightToLeft = RightToLeft.No;
            txtVlTotal.SelectedText = "";
            txtVlTotal.SelectionLength = 0;
            txtVlTotal.SelectionStart = 0;
            txtVlTotal.ShortcutsEnabled = true;
            txtVlTotal.Size = new Size(135, 48);
            txtVlTotal.TabIndex = 18;
            txtVlTotal.TabStop = false;
            txtVlTotal.TextAlign = HorizontalAlignment.Left;
            txtVlTotal.TrailingIcon = null;
            txtVlTotal.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(363, 22);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(98, 48);
            txtQuantidade.TabIndex = 17;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtVlUnitario
            // 
            txtVlUnitario.AnimateReadOnly = false;
            txtVlUnitario.AutoCompleteMode = AutoCompleteMode.None;
            txtVlUnitario.AutoCompleteSource = AutoCompleteSource.None;
            txtVlUnitario.BackgroundImageLayout = ImageLayout.None;
            txtVlUnitario.CharacterCasing = CharacterCasing.Normal;
            txtVlUnitario.Depth = 0;
            txtVlUnitario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVlUnitario.HideSelection = true;
            txtVlUnitario.Hint = "Valor Unitário";
            txtVlUnitario.LeadingIcon = null;
            txtVlUnitario.Location = new Point(224, 23);
            txtVlUnitario.MaxLength = 32767;
            txtVlUnitario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVlUnitario.Name = "txtVlUnitario";
            txtVlUnitario.PasswordChar = '\0';
            txtVlUnitario.PrefixSuffixText = null;
            txtVlUnitario.ReadOnly = false;
            txtVlUnitario.RightToLeft = RightToLeft.No;
            txtVlUnitario.SelectedText = "";
            txtVlUnitario.SelectionLength = 0;
            txtVlUnitario.SelectionStart = 0;
            txtVlUnitario.ShortcutsEnabled = true;
            txtVlUnitario.Size = new Size(133, 48);
            txtVlUnitario.TabIndex = 16;
            txtVlUnitario.TabStop = false;
            txtVlUnitario.TextAlign = HorizontalAlignment.Left;
            txtVlUnitario.TrailingIcon = null;
            txtVlUnitario.UseSystemPasswordChar = false;
            txtVlUnitario.Click += txtVlUnitario_Click;
            // 
            // cboProduto
            // 
            cboProduto.AutoResize = false;
            cboProduto.BackColor = Color.FromArgb(255, 255, 255);
            cboProduto.Depth = 0;
            cboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduto.DropDownHeight = 174;
            cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduto.DropDownWidth = 121;
            cboProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduto.FormattingEnabled = true;
            cboProduto.Hint = "Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(3, 22);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(215, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 150);
            dataGridView1.TabIndex = 13;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(9, 61);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(489, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 14;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário/Vendedor";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(222, 6);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(276, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 15;
            // 
            // txtValorTotalVenda
            // 
            txtValorTotalVenda.AnimateReadOnly = false;
            txtValorTotalVenda.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTotalVenda.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTotalVenda.BackgroundImageLayout = ImageLayout.None;
            txtValorTotalVenda.CharacterCasing = CharacterCasing.Normal;
            txtValorTotalVenda.Depth = 0;
            txtValorTotalVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotalVenda.HideSelection = true;
            txtValorTotalVenda.Hint = "Valor Total";
            txtValorTotalVenda.LeadingIcon = null;
            txtValorTotalVenda.Location = new Point(504, 62);
            txtValorTotalVenda.MaxLength = 32767;
            txtValorTotalVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotalVenda.Name = "txtValorTotalVenda";
            txtValorTotalVenda.PasswordChar = '\0';
            txtValorTotalVenda.PrefixSuffixText = null;
            txtValorTotalVenda.ReadOnly = true;
            txtValorTotalVenda.RightToLeft = RightToLeft.No;
            txtValorTotalVenda.SelectedText = "";
            txtValorTotalVenda.SelectionLength = 0;
            txtValorTotalVenda.SelectionStart = 0;
            txtValorTotalVenda.ShortcutsEnabled = true;
            txtValorTotalVenda.Size = new Size(107, 48);
            txtValorTotalVenda.TabIndex = 16;
            txtValorTotalVenda.TabStop = false;
            txtValorTotalVenda.TextAlign = HorizontalAlignment.Left;
            txtValorTotalVenda.TrailingIcon = null;
            txtValorTotalVenda.UseSystemPasswordChar = false;
            // 
            // txtDataVenda
            // 
            txtDataVenda.AllowPromptAsInput = true;
            txtDataVenda.AnimateReadOnly = false;
            txtDataVenda.AsciiOnly = false;
            txtDataVenda.BackgroundImageLayout = ImageLayout.None;
            txtDataVenda.BeepOnError = false;
            txtDataVenda.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.Depth = 0;
            txtDataVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataVenda.HidePromptOnLeave = false;
            txtDataVenda.HideSelection = true;
            txtDataVenda.Hint = "Data Venda";
            txtDataVenda.InsertKeyMode = InsertKeyMode.Default;
            txtDataVenda.LeadingIcon = null;
            txtDataVenda.Location = new Point(9, 7);
            txtDataVenda.Mask = "99/99/9999";
            txtDataVenda.MaxLength = 32767;
            txtDataVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.PasswordChar = '\0';
            txtDataVenda.PrefixSuffixText = null;
            txtDataVenda.PromptChar = '_';
            txtDataVenda.ReadOnly = false;
            txtDataVenda.RejectInputOnFirstFailure = false;
            txtDataVenda.ResetOnPrompt = true;
            txtDataVenda.ResetOnSpace = true;
            txtDataVenda.RightToLeft = RightToLeft.No;
            txtDataVenda.SelectedText = "";
            txtDataVenda.SelectionLength = 0;
            txtDataVenda.SelectionStart = 0;
            txtDataVenda.ShortcutsEnabled = true;
            txtDataVenda.Size = new Size(177, 48);
            txtDataVenda.SkipLiterals = true;
            txtDataVenda.TabIndex = 17;
            txtDataVenda.TabStop = false;
            txtDataVenda.Text = "  /  /";
            txtDataVenda.TextAlign = HorizontalAlignment.Center;
            txtDataVenda.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.TrailingIcon = null;
            txtDataVenda.UseSystemPasswordChar = false;
            txtDataVenda.ValidatingType = null;
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 678);
            Location = new Point(0, 0);
            Name = "CadastroVenda";
            Text = "Cadastro de Vendas";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTotalVenda;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataVenda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVlUnitario;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVlTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
    }
}