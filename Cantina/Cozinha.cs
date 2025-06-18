using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidoFinalizado.Pedidos)
            {
                if (pedido.Status == Status.PREPARANDO)
                    pedidos.Items.Add(pedido);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido produtoSelecionado = (Pedido)pedidos.SelectedItem;
            produtoSelecionado.Status = Status.PRONTO;
            pedidos.Items.Remove(produtoSelecionado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            balcão balcão = new balcão();
            balcão.Show();
        }
    }
}
