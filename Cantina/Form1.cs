using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Cantina
{
    public partial class vendas : Form
    {
        decimal total = 0;
        static List<Itens> produto = new List<Itens>();
        public vendas()
        {
            InitializeComponent();

            Menu.DisplayMember = "Nome";
            Menu.ValueMember = "Valor";
            Pedido.DisplayMember = "Nome";
            Pedido.ValueMember = "Valor";
            Pedido.DisplayMember = "ToString";

            Menu.Items.Add(new Itens { Nome = "Pão de queijo ", Valor = 3.50m, Chapa = false });
            Menu.Items.Add(new Itens { Nome = "Coxinha ", Valor = 5.00m, Chapa = false });
            Menu.Items.Add(new Itens { Nome = "Pastel de Carne ", Valor = 6.00m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = "Pastel de Queijo ", Valor = 5.50m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = "Suco Natural(300ml) ", Valor = 4.00m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = "Refrigerante Lata ", Valor = 4.50m, Chapa = false });
            Menu.Items.Add(new Itens { Nome = "Hamburúrguer Simples ", Valor = 8.00m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = "Hamburúrguer com Queijo ", Valor = 9.00m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = " X-Tudo ", Valor = 12.00m, Chapa = true });
            Menu.Items.Add(new Itens { Nome = "Agua Mineral(500ml) ", Valor = 2.50m, Chapa = false });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vendas.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu.SelectedItem != null)
            {
                if (Menu.SelectedItem is Itens itemSelecionado)
                {

                    if (int.TryParse(Quantidadebtn.Text, out int quantidade) && quantidade >= 1)
                    {

                        Itens itemPedido = new Itens
                        {
                            Nome = itemSelecionado.Nome,
                            Valor = itemSelecionado.Valor,
                            Quantidade = quantidade,
                            Hora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                        };

                        Pedido.Items.Add(itemPedido);
                        total += itemPedido.Valor * itemPedido.Quantidade;
                        lblTotal.Text = total.ToString("F2");
                        Quantidadebtn.Text = "1";
                        produto.Add(itemPedido);
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
                    produto.Remove(itemRemovido);

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
            string Viagem = CheckBox.Checked ? "Sim" : "Não";
            string pagamento = comboBox1.SelectedItem as string;
            string Cliente = NomeCliente.Text;

            if (string.IsNullOrEmpty(Cliente))
            {
                MessageBox.Show("Insira o nome do cliente");

            }
            else
            {
                if ((Pedido.Items.Count == 0) && string.IsNullOrEmpty(pagamento))
                {
                    MessageBox.Show("AÇÃO INDISPONIVEL, ESCOLHA UM METODO DE PAGAMENTO!");
                }

                if (pagamento == "Dinheiro")
                {
                    string escolha = Interaction.InputBox("Valor pago: ", $"Valor a ser pago: {total}");
                    decimal valorPago = decimal.Parse(escolha);
                    if (valorPago < total)
                    {
                        MessageBox.Show("Valor insuficiente");
                        return;
                    }


                    if (valorPago > total)
                    {

                        decimal troco = valorPago - total;
                        MessageBox.Show($"Seu troco = {troco}");
                        MessageBox.Show($"""
                        
                        Nome do do Cliente: {Cliente} 
                        Total: {total}
                        Forma de pagamento:{pagamento} 
                        Valor Pago: {valorPago}
                        Para Viagem? {Viagem}
                        Compra aprovada, obrigado pela preferencia, {Cliente}
                        Pedido:
                        """);
                        Pedido.Items.Clear();
                        NomeCliente.Clear();
                        total = 0;
                        lblTotal.Text = total.ToString("F2");
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show($"""
                        
                        Nome do do Cliente: {Cliente} 
                        Total: {total}
                        Forma de pagamento:{pagamento} 
                        Valor Pago: {valorPago}
                        Para Viagem? {Viagem}
                        Compra aprovada, obrigado pela preferencia, {Cliente}
                        
                        """);
                        Pedido.Items.Clear();
                        NomeCliente.Clear();
                        total = 0;
                        lblTotal.Text = total.ToString("F2");
                        comboBox1.SelectedIndex = -1;
                    }
                }


                else
                {
                    Pedido.Items.Clear();
                    MessageBox.Show("Seu Total = R$" + total.ToString("F2"));
                    MessageBox.Show($"""
                        
                        Nome do do Cliente: {Cliente} 
                        Total: {total}
                        Forma de pagamento:{pagamento} 
                        Para Viagem? {Viagem}
                        Compra aprovada, obrigado pela preferencia, {Cliente}
                        
                        """);
                    total = 0;
                    lblTotal.Text = total.ToString("F2");
                    comboBox1.SelectedIndex = -1;
                    Pedido.Items.Clear();
                    NomeCliente.Clear();

                }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            balcão balcão = new balcão();
            balcão.ShowDialog();

        }
    }
}
