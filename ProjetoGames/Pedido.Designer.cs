namespace ProjetoGames
{
    partial class Pedido
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.chk2contas = new System.Windows.Forms.CheckBox();
            this.chk2controles = new System.Windows.Forms.CheckBox();
            this.chkTotalPass = new System.Windows.Forms.CheckBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(41, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.Location = new System.Drawing.Point(245, 90);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(126, 20);
            this.txtValorJogo.TabIndex = 1;
            this.txtValorJogo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(421, 90);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(126, 20);
            this.txtValorOpcionais.TabIndex = 2;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(602, 90);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(126, 20);
            this.txtValorTotal.TabIndex = 3;
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Location = new System.Drawing.Point(249, 42);
            this.lblValorJogo.Name = "lblValorJogo";
            this.lblValorJogo.Size = new System.Drawing.Size(94, 13);
            this.lblValorJogo.TabIndex = 4;
            this.lblValorJogo.Text = "VALOR DO JOGO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(418, 38);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 5;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(599, 42);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 6;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(412, 190);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(126, 20);
            this.txtPesquisar.TabIndex = 14;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(340, 197);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(41, 105);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposJogos.TabIndex = 7;
            this.cmbTiposJogos.Text = "TIPOS DE JOGOS";
            this.cmbTiposJogos.SelectedIndexChanged += new System.EventHandler(this.cmbTiposJogos_SelectedIndexChanged);
            // 
            // chk2contas
            // 
            this.chk2contas.AutoSize = true;
            this.chk2contas.Location = new System.Drawing.Point(16, 31);
            this.chk2contas.Name = "chk2contas";
            this.chk2contas.Size = new System.Drawing.Size(79, 17);
            this.chk2contas.TabIndex = 0;
            this.chk2contas.Text = "2 CONTAS";
            this.chk2contas.UseVisualStyleBackColor = true;
            // 
            // chk2controles
            // 
            this.chk2controles.AutoSize = true;
            this.chk2controles.Location = new System.Drawing.Point(16, 54);
            this.chk2controles.Name = "chk2controles";
            this.chk2controles.Size = new System.Drawing.Size(101, 17);
            this.chk2controles.TabIndex = 1;
            this.chk2controles.Text = "2 CONTROLES";
            this.chk2controles.UseVisualStyleBackColor = true;
            // 
            // chkTotalPass
            // 
            this.chkTotalPass.AutoSize = true;
            this.chkTotalPass.Location = new System.Drawing.Point(16, 77);
            this.chkTotalPass.Name = "chkTotalPass";
            this.chkTotalPass.Size = new System.Drawing.Size(134, 17);
            this.chkTotalPass.TabIndex = 2;
            this.chkTotalPass.Text = "TOTAL PASS GAMER";
            this.chkTotalPass.UseVisualStyleBackColor = true;
            this.chkTotalPass.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkTesteDrive
            // 
            this.chkTesteDrive.AutoSize = true;
            this.chkTesteDrive.Location = new System.Drawing.Point(16, 100);
            this.chkTesteDrive.Name = "chkTesteDrive";
            this.chkTesteDrive.Size = new System.Drawing.Size(97, 17);
            this.chkTesteDrive.TabIndex = 3;
            this.chkTesteDrive.Text = "TESTE DRIVE";
            this.chkTesteDrive.UseVisualStyleBackColor = true;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTesteDrive);
            this.grpOpcionais.Controls.Add(this.chkTotalPass);
            this.grpOpcionais.Controls.Add(this.chk2controles);
            this.grpOpcionais.Controls.Add(this.chk2contas);
            this.grpOpcionais.Location = new System.Drawing.Point(42, 149);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(155, 134);
            this.grpOpcionais.TabIndex = 8;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(226, 408);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 30);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(607, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 30);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(41, 313);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(683, 79);
            this.dgvPedido.TabIndex = 9;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(421, 408);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 30);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(42, 408);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 30);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTiposJogos);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorJogo);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorJogo);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
        private System.Windows.Forms.CheckBox chk2contas;
        private System.Windows.Forms.CheckBox chk2controles;
        private System.Windows.Forms.CheckBox chkTotalPass;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
    }
}