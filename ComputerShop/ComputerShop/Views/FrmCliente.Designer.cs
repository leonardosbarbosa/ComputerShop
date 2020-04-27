namespace ComputerShop.Views
{
    partial class FrmCliente
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnAlterarDadosCli = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtIDCli = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblIDCli = new System.Windows.Forms.Label();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.gpbPesquisaCli = new System.Windows.Forms.GroupBox();
            this.dgvPesquisaCli = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.gpbCliente.SuspendLayout();
            this.gpbPesquisaCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnAlterarDadosCli);
            this.gpbCliente.Controls.Add(this.btnExcluirCli);
            this.gpbCliente.Controls.Add(this.mtbCelular);
            this.gpbCliente.Controls.Add(this.lblCelular);
            this.gpbCliente.Controls.Add(this.mtbCPF);
            this.gpbCliente.Controls.Add(this.mtbRG);
            this.gpbCliente.Controls.Add(this.mtbNascimento);
            this.gpbCliente.Controls.Add(this.txtEndereco);
            this.gpbCliente.Controls.Add(this.txtNomeCli);
            this.gpbCliente.Controls.Add(this.txtIDCli);
            this.gpbCliente.Controls.Add(this.lblNascimento);
            this.gpbCliente.Controls.Add(this.lblRG);
            this.gpbCliente.Controls.Add(this.lblEndereco);
            this.gpbCliente.Controls.Add(this.lblCPF);
            this.gpbCliente.Controls.Add(this.lblNomeCli);
            this.gpbCliente.Controls.Add(this.lblIDCli);
            this.gpbCliente.Location = new System.Drawing.Point(11, 280);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(776, 245);
            this.gpbCliente.TabIndex = 5;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Dados do Cliente";
            // 
            // btnAlterarDadosCli
            // 
            this.btnAlterarDadosCli.Location = new System.Drawing.Point(519, 107);
            this.btnAlterarDadosCli.Name = "btnAlterarDadosCli";
            this.btnAlterarDadosCli.Size = new System.Drawing.Size(85, 51);
            this.btnAlterarDadosCli.TabIndex = 3;
            this.btnAlterarDadosCli.Text = "Alterar Dados do Cliente";
            this.btnAlterarDadosCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Location = new System.Drawing.Point(658, 107);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(86, 51);
            this.btnExcluirCli.TabIndex = 4;
            this.btnExcluirCli.Text = "Excluir Cliente";
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(102, 184);
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(125, 20);
            this.mtbCelular.TabIndex = 11;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(50, 187);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(102, 107);
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(170, 20);
            this.mtbCPF.TabIndex = 9;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(332, 107);
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(140, 20);
            this.mtbRG.TabIndex = 9;
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Location = new System.Drawing.Point(346, 184);
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(126, 20);
            this.mtbNascimento.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 145);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(370, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(102, 76);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(370, 20);
            this.txtNomeCli.TabIndex = 7;
            // 
            // txtIDCli
            // 
            this.txtIDCli.Location = new System.Drawing.Point(102, 36);
            this.txtIDCli.Name = "txtIDCli";
            this.txtIDCli.Size = new System.Drawing.Size(59, 20);
            this.txtIDCli.TabIndex = 6;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(233, 187);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblNascimento.TabIndex = 5;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(300, 110);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 4;
            this.lblRG.Text = "RG:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(40, 148);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(66, 110);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(11, 79);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome Completo:";
            // 
            // lblIDCli
            // 
            this.lblIDCli.AutoSize = true;
            this.lblIDCli.Location = new System.Drawing.Point(40, 39);
            this.lblIDCli.Name = "lblIDCli";
            this.lblIDCli.Size = new System.Drawing.Size(56, 13);
            this.lblIDCli.TabIndex = 0;
            this.lblIDCli.Text = "ID Cliente:";
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Location = new System.Drawing.Point(11, 542);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(90, 51);
            this.btnNovoCli.TabIndex = 4;
            this.btnNovoCli.Text = "Novo Cliente";
            this.btnNovoCli.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisaCli
            // 
            this.gpbPesquisaCli.Controls.Add(this.dgvPesquisaCli);
            this.gpbPesquisaCli.Controls.Add(this.btnPesquisar);
            this.gpbPesquisaCli.Controls.Add(this.txtPesquisa);
            this.gpbPesquisaCli.Controls.Add(this.rdbCPF);
            this.gpbPesquisaCli.Controls.Add(this.rdbNome);
            this.gpbPesquisaCli.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisaCli.Name = "gpbPesquisaCli";
            this.gpbPesquisaCli.Size = new System.Drawing.Size(775, 262);
            this.gpbPesquisaCli.TabIndex = 3;
            this.gpbPesquisaCli.TabStop = false;
            this.gpbPesquisaCli.Text = "Pesquisar";
            // 
            // dgvPesquisaCli
            // 
            this.dgvPesquisaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaCli.Location = new System.Drawing.Point(6, 76);
            this.dgvPesquisaCli.Name = "dgvPesquisaCli";
            this.dgvPesquisaCli.Size = new System.Drawing.Size(764, 174);
            this.dgvPesquisaCli.TabIndex = 6;
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
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(65, 38);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 1;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
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
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnNovoCli);
            this.Controls.Add(this.gpbPesquisaCli);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbPesquisaCli.ResumeLayout(false);
            this.gpbPesquisaCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnAlterarDadosCli;
        private System.Windows.Forms.Button btnExcluirCli;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbNascimento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtIDCli;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblIDCli;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.GroupBox gpbPesquisaCli;
        private System.Windows.Forms.DataGridView dgvPesquisaCli;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbNome;
    }
}