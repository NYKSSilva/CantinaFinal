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
            Pedido.DisplayMember = "ToString";

            Menu.Items.Add(new Itens { Nome = "Pão de queijo ", Valor = 3.50 });
            Menu.Items.Add(new Itens { Nome = "Coxinha ", Valor = 5.00 });
            Menu.Items.Add(new Itens { Nome = "Pastel de Carne ", Valor = 6.00 });
            Menu.Items.Add(new Itens { Nome = "Pastel de Queijo ", Valor = 5.50 });
            Menu.Items.Add(new Itens { Nome = "Suco Natural(300ml) ", Valor = 4.00 });
            Menu.Items.Add(new Itens { Nome = "Refrigerante Lata ", Valor = 4.50 });
            Menu.Items.Add(new Itens { Nome = "Hamburúrguer Simples ", Valor = 8.00 });
            Menu.Items.Add(new Itens { Nome = "Hamburúrguer com Queijo ", Valor = 9.00 });
            Menu.Items.Add(new Itens { Nome = " X-Tudo ", Valor = 12.00 });
            Menu.Items.Add(new Itens { Nome = "Agua Mineral(500ml) ", Valor = 2.50 });

            //btnQuantidade.Minimum = 1;
            //btnQuantidade.Maximum = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu.SelectedItem != null)
            {
                if (Menu.SelectedItem is Itens itemSelecionado)
                {
                    if (int.TryParse(Quantidadebtn.Text, out int quantidade) && quantidade > 0)
                    {

                        Itens itemPedido = new Itens
                        {
                            Nome = itemSelecionado.Nome,
                            Valor = itemSelecionado.Valor,
                            Quantidade = quantidade
                        };

                        Pedido.Items.Add(itemPedido);
                        total += itemPedido.Valor * itemPedido.Quantidade;
                        lblTotal.Text = total.ToString("F2");
                    }

                    else
                    {
                        MessageBox.Show("Quantidade inválida.");
                    }
                }

                else
                {
                    MessageBox.Show("Ação inválida. Selecione um item da lista.");
                }
            }
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pedido != null)
            {
                if (Pedido.SelectedItem is Itens itemRemovido)
                {
                    total -= itemRemovido.Valor * itemRemovido.Quantidade;
                    Pedido.Items.Remove(itemRemovido);
                    lblTotal.Text = total.ToString("F2");
                }
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
            if (Pedido.Items.Count == 0)
            {
                MessageBox.Show("SELECIONE AlGUM ITEM");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pedido_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
