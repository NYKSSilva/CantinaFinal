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
    public partial class balcão : Form
    {
        public balcão()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void historico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (Pedido pedido in PedidoFinalizado.pedidoFinalizado)
            //{

            //    if (pedido.Status == Status.PRONTO)
            //        pedidos.Items.Add(pedido);

            //    else
            //    {
            //        historico.Items.Add(pedido);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
