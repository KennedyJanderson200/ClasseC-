using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btns_PaginaCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro efetuado com sucesso");


        }

        private void button1_Click(object sender, EventArgs e)
        {
         Form2 novaform = new Form2();
          novaform.Show();
        }
    }
}
