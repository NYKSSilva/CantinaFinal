namespace Cantina
{
    partial class forms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pedido = new ListBox();
            Menu = new ListBox();
            button1 = new Button();
            button2 = new Button();
            lblMostradorDeTotal = new Label();
            btnPagamento = new Button();
            label2 = new Label();
            lblTotal = new Label();
            Quantidadebtn = new TextBox();
            label1 = new Label();
            label3 = new Label();
            NomeCliente = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            CheckBox = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Pedido
            // 
            Pedido.BackColor = Color.FromArgb(17, 25, 12);
            Pedido.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedido.ForeColor = Color.FromArgb(230, 255, 0);
            Pedido.FormattingEnabled = true;
            Pedido.ItemHeight = 21;
            Pedido.Location = new Point(632, 142);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(296, 277);
            Pedido.TabIndex = 0;
            Pedido.SelectedIndexChanged += Pedido_SelectedIndexChanged_1;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(230, 255, 0);
            Menu.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.Black;
            Menu.FormattingEnabled = true;
            Menu.ItemHeight = 21;
            Menu.Items.AddRange(new object[] { "" });
            Menu.Location = new Point(49, 107);
            Menu.Name = "Menu";
            Menu.Size = new Size(319, 277);
            Menu.TabIndex = 1;
            Menu.SelectedIndexChanged += Menu_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Agrandir", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(49, 419);
            button1.Name = "button1";
            button1.Size = new Size(157, 36);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Agrandir", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(220, 417);
            button2.Name = "button2";
            button2.Size = new Size(148, 36);
            button2.TabIndex = 3;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblMostradorDeTotal
            // 
            lblMostradorDeTotal.AutoSize = true;
            lblMostradorDeTotal.BackColor = Color.FromArgb(17, 25, 12);
            lblMostradorDeTotal.Font = new Font("Agrandir", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostradorDeTotal.ForeColor = Color.FromArgb(230, 255, 0);
            lblMostradorDeTotal.Location = new Point(810, 512);
            lblMostradorDeTotal.Name = "lblMostradorDeTotal";
            lblMostradorDeTotal.Size = new Size(105, 36);
            lblMostradorDeTotal.TabIndex = 5;
            lblMostradorDeTotal.Text = "TOTAL:";
            lblMostradorDeTotal.Click += label1_Click;
            // 
            // btnPagamento
            // 
            btnPagamento.BackColor = Color.Black;
            btnPagamento.Font = new Font("Agrandir", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagamento.ForeColor = Color.FromArgb(230, 255, 0);
            btnPagamento.Location = new Point(829, 561);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(166, 41);
            btnPagamento.TabIndex = 6;
            btnPagamento.Text = "Finalizar";
            btnPagamento.UseVisualStyleBackColor = false;
            btnPagamento.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(593, 426);
            label2.Name = "label2";
            label2.Size = new Size(0, 36);
            label2.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(17, 25, 12);
            lblTotal.Font = new Font("Agrandir", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(230, 255, 0);
            lblTotal.Location = new Point(921, 512);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 36);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "  0,00";
            lblTotal.Click += label3_Click;
            // 
            // Quantidadebtn
            // 
            Quantidadebtn.BackColor = Color.Black;
            Quantidadebtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantidadebtn.ForeColor = Color.FromArgb(230, 255, 0);
            Quantidadebtn.Location = new Point(220, 471);
            Quantidadebtn.Name = "Quantidadebtn";
            Quantidadebtn.Size = new Size(110, 29);
            Quantidadebtn.TabIndex = 12;
            Quantidadebtn.TextChanged += Quantidade_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 472);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 13;
            label1.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 107);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 14;
            label3.Text = "Cliente:";
            // 
            // NomeCliente
            // 
            NomeCliente.BackColor = Color.FromArgb(17, 25, 12);
            NomeCliente.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeCliente.ForeColor = Color.FromArgb(230, 255, 0);
            NomeCliente.Location = new Point(645, 107);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(283, 29);
            NomeCliente.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.ForeColor = Color.FromArgb(230, 255, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "PIX", "Cartão de Credito", "Cartão de Debito", "Vale Alimentação", "Vale Refeição" });
            comboBox1.Location = new Point(934, 429);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 21);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Metodo";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(756, 429);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 17;
            label4.Text = "Metodo de Pagamento:";
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.BackColor = Color.Black;
            CheckBox.Font = new Font("Agrandir", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBox.ForeColor = Color.FromArgb(230, 255, 0);
            CheckBox.Location = new Point(934, 456);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(103, 21);
            CheckBox.TabIndex = 18;
            CheckBox.Text = "Para Viagem";
            CheckBox.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bolt_logo;
            pictureBox3.Location = new Point(955, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(138, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-31, -68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 709);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(230, 255, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(49, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 20);
            dateTimePicker1.TabIndex = 21;
            // 
            // forms
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 643);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox3);
            Controls.Add(CheckBox);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(NomeCliente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Quantidadebtn);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(btnPagamento);
            Controls.Add(lblMostradorDeTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Menu);
            Controls.Add(Pedido);
            Controls.Add(pictureBox2);
            Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "forms";
            Text = "Cantina";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pedido;
        private ListBox Menu;
        private Button button1;
        private Button button2;
        private Label lblMostradorDeTotal;
        private Button btnPagamento;
        private Label label2;
        private Label lblTotal;
        private NumericUpDown btnQuantidade;
        private TextBox Quantidadebtn;
        private Label label1;
        private Label label3;
        private TextBox NomeCliente;
        private ComboBox comboBox1;
        private Label label4;
        private CheckBox CheckBox;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
    }
}
