using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Cantina
{
    public partial class vendas : Form
    {
        decimal total = 0;
        public List<Itens> carrinho = new List<Itens>();
        public vendas()
        {
            InitializeComponent();

            Menu.Items.Add(new Itens("Pão de queijo ", 3.50m, false));
            Menu.Items.Add(new Itens("Coxinha ", 5.00m, false));
            Menu.Items.Add(new Itens("Pastel de Carne ", 6.00m, true));
            Menu.Items.Add(new Itens("Pastel de Queijo ", 5.50m, true));
            Menu.Items.Add(new Itens("Suco Natural(300ml) ", 4.00m, true));
            Menu.Items.Add(new Itens("Refrigerante Lata ", 4.50m, false));
            Menu.Items.Add(new Itens("Hamburúrguer Simples ", 8.00m, true));
            Menu.Items.Add(new Itens("Hamburúrguer com Queijo ", 9.00m, true));
            Menu.Items.Add(new Itens(" X-Tudo ", 12.00m, true));
            Menu.Items.Add(new Itens("Agua Mineral(500ml) ", 2.50m, false));
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

                        Itens itemPedido = new Itens(itemSelecionado.Nome, itemSelecionado.Valor, itemSelecionado.Chapa)
                        {
                            Quantidade = quantidade,
                        };

                        carrinho.Add(itemPedido);
                        pedido.Items.Add(itemPedido);
                        total += itemPedido.Valor * itemPedido.Quantidade;
                        lblTotal.Text = total.ToString("F2");
                        Quantidadebtn.Text = "1";

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
            if (pedido != null)
            {
                if (pedido.SelectedItem is Itens itemRemovido)
                {
                    total -= itemRemovido.Valor * itemRemovido.Quantidade;
                    pedido.Items.Remove(itemRemovido);
                    lblTotal.Text = total.ToString("F2");
                    carrinho.Remove(itemRemovido);
                    

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
                if ((pedido.Items.Count == 0) && string.IsNullOrEmpty(pagamento))
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

                        pedido.Items.Clear();
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
                        pedido.Items.Clear();
                        NomeCliente.Clear();
                        total = 0;
                        lblTotal.Text = total.ToString("F2");
                        comboBox1.SelectedIndex = -1;
                    }
                }
                else
                {
                   
                    pedido.Items.Clear();
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
                    pedido.Items.Clear();
                    NomeCliente.Clear();
                }

                bool pedidoChapa = carrinho.Any(p => p.Chapa);
                Status pedidoStatus = pedidoChapa ? Status.PREPARANDO : Status.PRONTO;

                var novoPedido = new Pedido (Cliente, pagamento, DateTime.Now, CheckBox.Checked, new List<Itens>(carrinho), pedidoStatus);
                PedidoFinalizado.Pedidos.Add(novoPedido);
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
