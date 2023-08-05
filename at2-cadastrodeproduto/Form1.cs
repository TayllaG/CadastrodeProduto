using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at2_cadastrodeproduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<double> produto = new List<double>();
            foreach (double p in produto)
            {
                MessageBox.Show(p.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_codigo.Text = "";
            tx_descricao.Text = "";
            tx_aquisicao.Text = "";
            tx_porcentagem.Text = "";
            lbl_valorVenda.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(tx_codigo.Text);
            string descricao = Convert.ToString(tx_descricao.Text);
            double aquisicao = Convert.ToDouble(tx_aquisicao.Text);
            double porcentagem = Convert.ToDouble(tx_porcentagem.Text);



           

            Produto prod = new Produto(codigo, descricao, aquisicao, porcentagem);

            lbl_valorVenda.Text = prod.Calculo(aquisicao,porcentagem).ToString("C2");

        }
    }
}
