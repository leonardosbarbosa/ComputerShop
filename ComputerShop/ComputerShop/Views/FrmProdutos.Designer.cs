namespace ComputerShop.Views
{
    partial class FrmProdutos
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
            this.gpbPesquisaProd = new System.Windows.Forms.GroupBox();
            this.dgvPesquisaProd = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.btnAlterarDadosProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnNovoProd = new System.Windows.Forms.Button();
            this.gpbPesquisaProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaProd)).BeginInit();
            this.gpbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisaProd
            // 
            this.gpbPesquisaProd.Controls.Add(this.dgvPesquisaProd);
            this.gpbPesquisaProd.Controls.Add(this.btnPesquisar);
            this.gpbPesquisaProd.Controls.Add(this.txtPesquisa);
            this.gpbPesquisaProd.Controls.Add(this.rdbID);
            this.gpbPesquisaProd.Controls.Add(this.rdbNome);
            this.gpbPesquisaProd.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisaProd.Name = "gpbPesquisaProd";
            this.gpbPesquisaProd.Size = new System.Drawing.Size(775, 262);
            this.gpbPesquisaProd.TabIndex = 4;
            this.gpbPesquisaProd.TabStop = false;
            this.gpbPesquisaProd.Text = "Pesquisar";
            // 
            // dgvPesquisaProd
            // 
            this.dgvPesquisaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaProd.Location = new System.Drawing.Point(6, 76);
            this.dgvPesquisaProd.Name = "dgvPesquisaProd";
            this.dgvPesquisaProd.Size = new System.Drawing.Size(764, 174);
            this.dgvPesquisaProd.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(345, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 22);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(116, 38);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(223, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(65, 38);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(36, 17);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(6, 38);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 0;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.btnAlterarDadosProd);
            this.gpbProduto.Controls.Add(this.btnExcluirProd);
            this.gpbProduto.Controls.Add(this.cbbCategoria);
            this.gpbProduto.Controls.Add(this.txtValorVenda);
            this.gpbProduto.Controls.Add(this.txtQuantidade);
            this.gpbProduto.Controls.Add(this.txtNome);
            this.gpbProduto.Controls.Add(this.txtID);
            this.gpbProduto.Controls.Add(this.lblValorVenda);
            this.gpbProduto.Controls.Add(this.lblCategoria);
            this.gpbProduto.Controls.Add(this.lblQuantidade);
            this.gpbProduto.Controls.Add(this.lblNome);
            this.gpbProduto.Controls.Add(this.lblID);
            this.gpbProduto.Location = new System.Drawing.Point(12, 308);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(770, 224);
            this.gpbProduto.TabIndex = 5;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Dados do Produto";
            // 
            // btnAlterarDadosProd
            // 
            this.btnAlterarDadosProd.Location = new System.Drawing.Point(445, 86);
            this.btnAlterarDadosProd.Name = "btnAlterarDadosProd";
            this.btnAlterarDadosProd.Size = new System.Drawing.Size(85, 51);
            this.btnAlterarDadosProd.TabIndex = 5;
            this.btnAlterarDadosProd.Text = "Alterar Dados do Produto";
            this.btnAlterarDadosProd.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Location = new System.Drawing.Point(584, 86);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(86, 51);
            this.btnExcluirProd.TabIndex = 6;
            this.btnExcluirProd.Text = "Excluir Produto";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(99, 135);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cbbCategoria.TabIndex = 2;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(99, 170);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(164, 20);
            this.txtValorVenda.TabIndex = 1;
            this.txtValorVenda.Text = "Ex: 458.89";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(99, 102);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(164, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Text = "Ex: 100, 200, 300...";
            this.txtQuantidade.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(83, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(14, 173);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(83, 13);
            this.lblValorVenda.TabIndex = 0;
            this.lblValorVenda.Text = "Valor de Venda:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(38, 138);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(28, 105);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(72, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // btnNovoProd
            // 
            this.btnNovoProd.Location = new System.Drawing.Point(12, 548);
            this.btnNovoProd.Name = "btnNovoProd";
            this.btnNovoProd.Size = new System.Drawing.Size(85, 51);
            this.btnNovoProd.TabIndex = 5;
            this.btnNovoProd.Text = "Novo Produto";
            this.btnNovoProd.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.btnNovoProd);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.gpbPesquisaProd);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.gpbPesquisaProd.ResumeLayout(false);
            this.gpbPesquisaProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaProd)).EndInit();
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisaProd;
        private System.Windows.Forms.DataGridView dgvPesquisaProd;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAlterarDadosProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnNovoProd;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}