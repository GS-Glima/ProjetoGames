
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGames
{
    public partial class Pedido : Form
    {
        bool mouseDown;
        private Point offset;

        conexao con = new conexao();
        public Pedido()
        {
       
            InitializeComponent();

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

            int raio = 15; // arredondamento (pode mudar)
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(btnNovo.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(btnNovo.Width - raio, btnNovo.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, btnNovo.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            btnNovo.Region = new Region(caminho);
            btnSalvar.Region = new Region(caminho);
            btnSair.Region = new Region(caminho);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTiposJogos.Items.Add("Jogo1");
            cmbTiposJogos.Items.Add("Jogo2");
            cmbTiposJogos.Items.Add("Jogo3");
            
        }

        private void cmbTiposJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorJogo = 0;
            double valorOpcionais = 0;
            double valorTotal = 0;

            if(cmbTiposJogos.SelectedIndex == 0)
            {
                valorJogo = 10;
            } else if (cmbTiposJogos.SelectedIndex == 1)
            {
                valorJogo = 15;
            } else if(cmbTiposJogos.SelectedIndex == 2)
            {
                valorJogo = 20;
            }

            if (chk2contas.Checked == true)
            {
               valorOpcionais =  valorOpcionais + 3;
            }
             if (chk2controles.Checked == true)
            {
                valorOpcionais =  valorOpcionais + 5;
            }
            if (chkTesteDrive.Checked == true)
            {
                valorOpcionais = valorOpcionais + 10;
            }
            if (chkTotalPass.Checked == true)
            {
                valorOpcionais = valorOpcionais + 15;
            }


             valorTotal = valorJogo + valorOpcionais;

            txtValorJogo.Text = valorJogo.ToString();
            txtValorOpcionais.Text = valorOpcionais.ToString();
            txtValorTotal.Text = valorTotal.ToString();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValorJogo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorJogo.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorTotal.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorTotal.Focus();
            }
            else
            {
                try
                {
                    string sql = "insert into tbPedido(tipoJogo,valorJogo,valorOpcao,valorTotal) values(@jogo,@vjogo,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@jogo", MySqlDbType.Text).Value = cmbTiposJogos.Text;
                    cmd.Parameters.Add("@vjogo", MySqlDbType.Text).Value = txtValorJogo.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorTotal.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTiposJogos.Text = "";
                    txtValorJogo.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorTotal.Text = "";
                    cmbTiposJogos.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }



        private void dgvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }
        public void CarregarPedidos()
        {
            try
            {
                if (dgvPedido.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um pedido válido.");
                    return;
                }

                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbTiposJogos.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorJogo.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorTotal.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao clicar: " + error.Message);
            }

        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {

                dgvPedido.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvar.Anchor = AnchorStyles.Bottom;
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            cmbTiposJogos.Text = "";
            txtValorJogo.Text = "";
            txtValorOpcionais.Text = "";
            txtValorTotal.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            borderBottom.Height = 1;
        }

        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
         
        }

        private void grpOpcionais_Paint(object sender, PaintEventArgs e)
        {

            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Coral, Color.Coral);
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void barra_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void barra_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
