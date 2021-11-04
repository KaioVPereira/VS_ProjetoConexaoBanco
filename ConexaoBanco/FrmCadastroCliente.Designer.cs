
namespace ConexaoBanco
{
    partial class FrmCadastroCliente
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
            this.LbCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.LbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.LbDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.LbNomeCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.BtGravar = new System.Windows.Forms.Button();
            this.BtFechar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtProcurar = new System.Windows.Forms.Button();
            this.BtLimpar = new System.Windows.Forms.Button();
            this.TxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.LbCelular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbCodigoCliente
            // 
            this.LbCodigoCliente.AutoSize = true;
            this.LbCodigoCliente.Location = new System.Drawing.Point(12, 9);
            this.LbCodigoCliente.Name = "LbCodigoCliente";
            this.LbCodigoCliente.Size = new System.Drawing.Size(93, 13);
            this.LbCodigoCliente.TabIndex = 0;
            this.LbCodigoCliente.Text = "Codigo do Cliente:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(15, 25);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // LbCPF
            // 
            this.LbCPF.AutoSize = true;
            this.LbCPF.Location = new System.Drawing.Point(116, 9);
            this.LbCPF.Name = "LbCPF";
            this.LbCPF.Size = new System.Drawing.Size(30, 13);
            this.LbCPF.TabIndex = 2;
            this.LbCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(119, 25);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // LbDataNascimento
            // 
            this.LbDataNascimento.AutoSize = true;
            this.LbDataNascimento.Location = new System.Drawing.Point(241, 9);
            this.LbDataNascimento.Name = "LbDataNascimento";
            this.LbDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.LbDataNascimento.TabIndex = 4;
            this.LbDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(244, 25);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // LbNomeCliente
            // 
            this.LbNomeCliente.AutoSize = true;
            this.LbNomeCliente.Location = new System.Drawing.Point(12, 63);
            this.LbNomeCliente.Name = "LbNomeCliente";
            this.LbNomeCliente.Size = new System.Drawing.Size(88, 13);
            this.LbNomeCliente.TabIndex = 6;
            this.LbNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // BtGravar
            // 
            this.BtGravar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtGravar.Location = new System.Drawing.Point(29, 132);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(75, 23);
            this.BtGravar.TabIndex = 8;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseVisualStyleBackColor = true;
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.IndianRed;
            this.BtFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtFechar.Location = new System.Drawing.Point(436, 155);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(48, 23);
            this.BtFechar.TabIndex = 9;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = false;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtExcluir.Location = new System.Drawing.Point(119, 132);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtExcluir.TabIndex = 10;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            // 
            // BtProcurar
            // 
            this.BtProcurar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtProcurar.Location = new System.Drawing.Point(213, 132);
            this.BtProcurar.Name = "BtProcurar";
            this.BtProcurar.Size = new System.Drawing.Size(75, 23);
            this.BtProcurar.TabIndex = 11;
            this.BtProcurar.Text = "Procurar";
            this.BtProcurar.UseVisualStyleBackColor = true;
            // 
            // BtLimpar
            // 
            this.BtLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtLimpar.Location = new System.Drawing.Point(308, 132);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(95, 23);
            this.BtLimpar.TabIndex = 12;
            this.BtLimpar.Text = "Limpar Campos";
            this.BtLimpar.UseVisualStyleBackColor = true;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(370, 25);
            this.TxtCelular.Mask = "99-99999-9999";
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(100, 20);
            this.TxtCelular.TabIndex = 13;
            // 
            // LbCelular
            // 
            this.LbCelular.AutoSize = true;
            this.LbCelular.Location = new System.Drawing.Point(373, 9);
            this.LbCelular.Name = "LbCelular";
            this.LbCelular.Size = new System.Drawing.Size(42, 13);
            this.LbCelular.TabIndex = 14;
            this.LbCelular.Text = "Celular:";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 178);
            this.ControlBox = false;
            this.Controls.Add(this.LbCelular);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.BtProcurar);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.LbNomeCliente);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.LbDataNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.LbCPF);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.LbCodigoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Clientes:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label LbCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label LbDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label LbNomeCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button BtGravar;
        private System.Windows.Forms.Button BtFechar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtProcurar;
        private System.Windows.Forms.Button BtLimpar;
        private System.Windows.Forms.MaskedTextBox TxtCelular;
        private System.Windows.Forms.Label LbCelular;
    }
}