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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chk2contas = new System.Windows.Forms.CheckBox();
            this.chk2controles = new System.Windows.Forms.CheckBox();
            this.chkTotalPass = new System.Windows.Forms.CheckBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.Location = new System.Drawing.Point(224, 91);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(126, 20);
            this.txtValorJogo.TabIndex = 1;
            this.txtValorJogo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(400, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(581, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 3;
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Location = new System.Drawing.Point(228, 43);
            this.lblValorJogo.Name = "lblValorJogo";
            this.lblValorJogo.Size = new System.Drawing.Size(94, 13);
            this.lblValorJogo.TabIndex = 4;
            this.lblValorJogo.Text = "VALOR DO JOGO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(397, 39);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 5;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(578, 43);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 6;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(41, 105);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposJogos.TabIndex = 7;
            this.cmbTiposJogos.Text = "TIPOS DE JOGOS";
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTiposJogos);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorJogo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtValorJogo);
            this.Controls.Add(this.textBox1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.CheckBox chkTotalPass;
        private System.Windows.Forms.CheckBox chk2controles;
        private System.Windows.Forms.CheckBox chk2contas;
    }
}