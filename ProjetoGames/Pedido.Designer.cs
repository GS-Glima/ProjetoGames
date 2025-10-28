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
            this.panel3 = new System.Windows.Forms.Panel();
            this.barra = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.chkTotalPass = new System.Windows.Forms.CheckBox();
            this.chk2controles = new System.Windows.Forms.CheckBox();
            this.chk2contas = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.panelCmb = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpOpcionais.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCmb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.barra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1712, 49);
            this.panel3.TabIndex = 17;
            // 
            // barra
            // 
            this.barra.Controls.Add(this.borderBottom);
            this.barra.Controls.Add(this.pictureBox1);
            this.barra.Controls.Add(this.btnFechar);
            this.barra.Controls.Add(this.btnMax);
            this.barra.Controls.Add(this.btnMin);
            this.barra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1712, 49);
            this.barra.TabIndex = 5;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barra_MouseMove);
            this.barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barra_MouseUp);
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.Coral;
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.ForeColor = System.Drawing.Color.Coral;
            this.borderBottom.Location = new System.Drawing.Point(0, 39);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(1712, 10);
            this.borderBottom.TabIndex = 5;
            this.borderBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoGames.Properties.Resources.controle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFechar.ForeColor = System.Drawing.Color.Coral;
            this.btnFechar.Location = new System.Drawing.Point(1671, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 36);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMax.ForeColor = System.Drawing.Color.Coral;
            this.btnMax.Location = new System.Drawing.Point(1625, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(38, 36);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "▭";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMin.ForeColor = System.Drawing.Color.Coral;
            this.btnMin.Location = new System.Drawing.Point(1581, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 36);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "_";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            this.dgvPedido.Size = new System.Drawing.Size(862, 255);
            this.dgvPedido.TabIndex = 9;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNovo.ForeColor = System.Drawing.Color.Coral;
            this.btnNovo.Location = new System.Drawing.Point(88, 494);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(176, 53);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Coral;
            this.btnSalvar.Location = new System.Drawing.Point(390, 494);
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
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.Coral;
            this.btnSair.Location = new System.Drawing.Point(687, 494);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 53);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblPesquisar.ForeColor = System.Drawing.Color.Coral;
            this.lblPesquisar.Location = new System.Drawing.Point(151, 132);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(83, 19);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPesquisar);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(678, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 665);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(55, 176);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 18);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorOpcionais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOpcionais.ForeColor = System.Drawing.Color.White;
            this.txtValorOpcionais.Location = new System.Drawing.Point(413, 357);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(187, 18);
            this.txtValorOpcionais.TabIndex = 2;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(413, 461);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(187, 18);
            this.txtValorTotal.TabIndex = 3;
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValorJogo.ForeColor = System.Drawing.Color.Coral;
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
            this.lblValorOpcionais.ForeColor = System.Drawing.Color.Coral;
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
            this.lblValorPagar.ForeColor = System.Drawing.Color.Coral;
            this.lblValorPagar.Location = new System.Drawing.Point(409, 418);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(112, 19);
            this.lblValorPagar.TabIndex = 6;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTesteDrive);
            this.grpOpcionais.Controls.Add(this.chkTotalPass);
            this.grpOpcionais.Controls.Add(this.chk2controles);
            this.grpOpcionais.Controls.Add(this.chk2contas);
            this.grpOpcionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOpcionais.ForeColor = System.Drawing.Color.Coral;
            this.grpOpcionais.Location = new System.Drawing.Point(55, 347);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpOpcionais.Size = new System.Drawing.Size(233, 237);
            this.grpOpcionais.TabIndex = 8;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            this.grpOpcionais.Paint += new System.Windows.Forms.PaintEventHandler(this.grpOpcionais_Paint);
            // 
            // chkTesteDrive
            // 
            this.chkTesteDrive.AutoSize = true;
            this.chkTesteDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTesteDrive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkTesteDrive.ForeColor = System.Drawing.Color.Coral;
            this.chkTesteDrive.Location = new System.Drawing.Point(24, 177);
            this.chkTesteDrive.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkTesteDrive.Name = "chkTesteDrive";
            this.chkTesteDrive.Size = new System.Drawing.Size(102, 23);
            this.chkTesteDrive.TabIndex = 3;
            this.chkTesteDrive.Text = "TESTE DRIVE";
            this.chkTesteDrive.UseVisualStyleBackColor = true;
            // 
            // chkTotalPass
            // 
            this.chkTotalPass.AutoSize = true;
            this.chkTotalPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTotalPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkTotalPass.ForeColor = System.Drawing.Color.Coral;
            this.chkTotalPass.Location = new System.Drawing.Point(24, 137);
            this.chkTotalPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkTotalPass.Name = "chkTotalPass";
            this.chkTotalPass.Size = new System.Drawing.Size(148, 23);
            this.chkTotalPass.TabIndex = 2;
            this.chkTotalPass.Text = "TOTAL PASS GAMER";
            this.chkTotalPass.UseVisualStyleBackColor = true;
            // 
            // chk2controles
            // 
            this.chk2controles.AutoSize = true;
            this.chk2controles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk2controles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk2controles.ForeColor = System.Drawing.Color.Coral;
            this.chk2controles.Location = new System.Drawing.Point(24, 94);
            this.chk2controles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chk2controles.Name = "chk2controles";
            this.chk2controles.Size = new System.Drawing.Size(114, 23);
            this.chk2controles.TabIndex = 1;
            this.chk2controles.Text = "2 CONTROLES";
            this.chk2controles.UseVisualStyleBackColor = true;
            // 
            // chk2contas
            // 
            this.chk2contas.AutoSize = true;
            this.chk2contas.FlatAppearance.BorderSize = 2;
            this.chk2contas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk2contas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk2contas.ForeColor = System.Drawing.Color.Coral;
            this.chk2contas.Location = new System.Drawing.Point(24, 54);
            this.chk2contas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chk2contas.Name = "chk2contas";
            this.chk2contas.Size = new System.Drawing.Size(89, 23);
            this.chk2contas.TabIndex = 0;
            this.chk2contas.Text = "2 CONTAS";
            this.chk2contas.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalcular.ForeColor = System.Drawing.Color.Coral;
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
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(53, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "CÓDIGO DO PEDIDO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCmb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.grpOpcionais);
            this.panel2.Controls.Add(this.lblValorPagar);
            this.panel2.Controls.Add(this.lblValorOpcionais);
            this.panel2.Controls.Add(this.lblValorJogo);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.txtValorOpcionais);
            this.panel2.Controls.Add(this.txtValorJogo);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 665);
            this.panel2.TabIndex = 18;
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.txtValorJogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorJogo.ForeColor = System.Drawing.Color.White;
            this.txtValorJogo.Location = new System.Drawing.Point(413, 255);
            this.txtValorJogo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(187, 18);
            this.txtValorJogo.TabIndex = 1;
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.cmbTiposJogos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTiposJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTiposJogos.ForeColor = System.Drawing.Color.Coral;
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(0, 0);
            this.cmbTiposJogos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(194, 25);
            this.cmbTiposJogos.TabIndex = 7;
            this.cmbTiposJogos.Text = "ESCOLHA OS JOGOS";
            // 
            // panelCmb
            // 
            this.panelCmb.Controls.Add(this.cmbTiposJogos);
            this.panelCmb.Location = new System.Drawing.Point(48, 254);
            this.panelCmb.Name = "panelCmb";
            this.panelCmb.Size = new System.Drawing.Size(194, 29);
            this.panelCmb.TabIndex = 17;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1712, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.panel3.ResumeLayout(false);
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCmb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.CheckBox chkTotalPass;
        private System.Windows.Forms.CheckBox chk2controles;
        private System.Windows.Forms.CheckBox chk2contas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel panelCmb;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
    }
}