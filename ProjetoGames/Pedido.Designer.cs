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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.chk2contas = new System.Windows.Forms.CheckBox();
            this.chk2controles = new System.Windows.Forms.CheckBox();
            this.chkTotalPass = new System.Windows.Forms.CheckBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOpcionais.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(55, 176);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 25);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorJogo.ForeColor = System.Drawing.Color.White;
            this.txtValorJogo.Location = new System.Drawing.Point(413, 255);
            this.txtValorJogo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(187, 25);
            this.txtValorJogo.TabIndex = 1;
            this.txtValorJogo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorOpcionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorOpcionais.ForeColor = System.Drawing.Color.White;
            this.txtValorOpcionais.Location = new System.Drawing.Point(413, 357);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(187, 25);
            this.txtValorOpcionais.TabIndex = 2;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(413, 461);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(187, 25);
            this.txtValorTotal.TabIndex = 3;
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValorJogo.ForeColor = System.Drawing.Color.White;
            this.lblValorJogo.Location = new System.Drawing.Point(409, 219);
            this.lblValorJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorJogo.Name = "lblValorJogo";
            this.lblValorJogo.Size = new System.Drawing.Size(118, 19);
            this.lblValorJogo.TabIndex = 4;
            this.lblValorJogo.Text = "VALOR DO JOGO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValorOpcionais.ForeColor = System.Drawing.Color.White;
            this.lblValorOpcionais.Location = new System.Drawing.Point(409, 319);
            this.lblValorOpcionais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(161, 19);
            this.lblValorOpcionais.TabIndex = 5;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValorPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorPagar.Location = new System.Drawing.Point(409, 418);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(112, 19);
            this.lblValorPagar.TabIndex = 6;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.cmbTiposJogos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTiposJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTiposJogos.ForeColor = System.Drawing.Color.White;
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(54, 269);
            this.cmbTiposJogos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(180, 25);
            this.cmbTiposJogos.TabIndex = 7;
            this.cmbTiposJogos.Text = "ESCOLHA OS JOGOS";
            this.cmbTiposJogos.SelectedIndexChanged += new System.EventHandler(this.cmbTiposJogos_SelectedIndexChanged);
            // 
            // chk2contas
            // 
            this.chk2contas.AutoSize = true;
            this.chk2contas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk2contas.ForeColor = System.Drawing.Color.White;
            this.chk2contas.Location = new System.Drawing.Point(24, 54);
            this.chk2contas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chk2contas.Name = "chk2contas";
            this.chk2contas.Size = new System.Drawing.Size(92, 23);
            this.chk2contas.TabIndex = 0;
            this.chk2contas.Text = "2 CONTAS";
            this.chk2contas.UseVisualStyleBackColor = true;
            // 
            // chk2controles
            // 
            this.chk2controles.AutoSize = true;
            this.chk2controles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk2controles.ForeColor = System.Drawing.Color.White;
            this.chk2controles.Location = new System.Drawing.Point(24, 94);
            this.chk2controles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chk2controles.Name = "chk2controles";
            this.chk2controles.Size = new System.Drawing.Size(117, 23);
            this.chk2controles.TabIndex = 1;
            this.chk2controles.Text = "2 CONTROLES";
            this.chk2controles.UseVisualStyleBackColor = true;
            // 
            // chkTotalPass
            // 
            this.chkTotalPass.AutoSize = true;
            this.chkTotalPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkTotalPass.ForeColor = System.Drawing.Color.White;
            this.chkTotalPass.Location = new System.Drawing.Point(24, 137);
            this.chkTotalPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkTotalPass.Name = "chkTotalPass";
            this.chkTotalPass.Size = new System.Drawing.Size(151, 23);
            this.chkTotalPass.TabIndex = 2;
            this.chkTotalPass.Text = "TOTAL PASS GAMER";
            this.chkTotalPass.UseVisualStyleBackColor = true;
            this.chkTotalPass.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkTesteDrive
            // 
            this.chkTesteDrive.AutoSize = true;
            this.chkTesteDrive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkTesteDrive.ForeColor = System.Drawing.Color.White;
            this.chkTesteDrive.Location = new System.Drawing.Point(24, 177);
            this.chkTesteDrive.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkTesteDrive.Name = "chkTesteDrive";
            this.chkTesteDrive.Size = new System.Drawing.Size(105, 23);
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
            this.grpOpcionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOpcionais.ForeColor = System.Drawing.Color.White;
            this.grpOpcionais.Location = new System.Drawing.Point(55, 347);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpOpcionais.Size = new System.Drawing.Size(233, 237);
            this.grpOpcionais.TabIndex = 8;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(54, 605);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(234, 50);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "CÓDIGO DO PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.grpOpcionais);
            this.panel2.Controls.Add(this.cmbTiposJogos);
            this.panel2.Controls.Add(this.lblValorPagar);
            this.panel2.Controls.Add(this.lblValorOpcionais);
            this.panel2.Controls.Add(this.lblValorJogo);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.txtValorOpcionais);
            this.panel2.Controls.Add(this.txtValorJogo);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 714);
            this.panel2.TabIndex = 18;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(30, 209);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.Size = new System.Drawing.Size(887, 376);
            this.dgvPedido.TabIndex = 9;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderSize = 2;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(30, 609);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(176, 53);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(392, 609);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 53);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(741, 609);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 53);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(284, 130);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(429, 25);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(151, 132);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(83, 19);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPesquisar);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(678, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 714);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(458, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pressione espaço";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1712, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
        private System.Windows.Forms.CheckBox chk2contas;
        private System.Windows.Forms.CheckBox chk2controles;
        private System.Windows.Forms.CheckBox chkTotalPass;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}