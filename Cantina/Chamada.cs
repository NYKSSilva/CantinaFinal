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
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidoFinalizado.Pedidos)
            {
                if (pedido.Status == Status.PREPARANDO || pedido.Status == Status.PRONTO)
                    Andamento.Items.Add(pedido.Cliente);
            }
            foreach (Pedido pedido in PedidoFinalizado.Pedidos)
            {
                if (pedido.Status == Status.ENTREGUE)
                    Pronto.Items.Add(pedido.Cliente);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            balcão balcão = new balcão();
            balcão.Show();
        }
    }
}
