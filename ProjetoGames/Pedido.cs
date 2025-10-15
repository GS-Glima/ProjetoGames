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
        }   
    }
}
