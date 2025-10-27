
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGames
{
    public partial class Pedido : Form
    {

        conexao con = new conexao();
        public Pedido()
        {
            InitializeComponent();
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
    }
}
