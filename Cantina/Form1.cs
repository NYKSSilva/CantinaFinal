using System.Numerics;

namespace Cantina
{
    public partial class Form1 : Form
    {
        double total = 0;

        public Form1()
        {
            InitializeComponent();

            Menu.DisplayMember = "Nome";
            Menu.ValueMember = "Valor";
            Pedido.DisplayMember = "Nome";
            Pedido.ValueMember = "Valor";

            Menu.Items.Add(new Itens { Nome = "Coxinha - R$ 5,00", Valor = 5.00 });
            Menu.Items.Add(new Itens { Nome = "Pastel - R$ 6,00", Valor = 6.00 });
            Menu.Items.Add(new Itens { Nome = "Refrigerante - R$ 4,00", Valor = 4.00 });
            Menu.Items.Add(new Itens { Nome = "Suco - R$ 3,00", Valor = 3.00 });
            Menu.Items.Add(new Itens { Nome = "Brigadeiro - R$ 2,00", Valor = 2.00 });
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu.SelectedItem != null)
            {
                Pedido.Items.Add(Menu.SelectedItem);

                Itens Item = (Itens)Menu.SelectedItem;

                total += Item.Valor;
                lblTotal.Text = total.ToString("F2");
            }
            else
            {
                MessageBox.Show("Pedido inválido.");
            }
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pedido.SelectedItem != null)
            {
                Itens Item = (Itens)Pedido.SelectedItem;

                total -= Item.Valor;
                lblTotal.Text = total.ToString("F2");

                Pedido.Items.Remove(Pedido.SelectedItem);
            }
            else
            {
                MessageBox.Show("Ação inválida. Escolha um item");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pedido.SelectedItem != null)
            {
                MessageBox.Show("SLELECiONE AlGO");
            }
            else
            {
                Pedido.Items.Clear();
                MessageBox.Show("Seu Total = R$" + total.ToString("F2"));
                total = 0;
                lblTotal.Text = total.ToString("F2");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
