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
            if (pedidos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido!!!!!!!");
                return;
            }

            var pedidoSelecionado = pedidos.SelectedItem as Pedido;

            if (historico.Items.Count == 5)
            {
                historico.Items.RemoveAt(4);
            }

            pedidoSelecionado.Status = Status.ENTREGUE;
            historico.Items.Insert(0, pedidoSelecionado);
            pedidos.Items.Remove(pedidoSelecionado);
        }

        private void historico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void balcão_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidoFinalizado.Pedidos)
            {
                if (pedido.Status == Status.PRONTO)
                    pedidos.Items.Add(pedido);

                else if (pedido.Status == Status.ENTREGUE)
                    historico.Items.Add(pedido);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            cozinha.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chamada chamada = new Chamada();
            chamada.Show();
        }
    }
}
