namespace Cantina
{
    partial class balcão
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pedidos = new ListBox();
            button1 = new Button();
            historico = new ListBox();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(931, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-35, -69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 709);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(230, 255, 0);
            label1.Location = new Point(26, 100);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 2;
            label1.Text = "Pedidos em Andamento";
            label1.Click += label1_Click;
            // 
            // pedidos
            // 
            pedidos.BackColor = Color.FromArgb(230, 255, 0);
            pedidos.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidos.FormattingEnabled = true;
            pedidos.ItemHeight = 20;
            pedidos.Location = new Point(12, 132);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(536, 304);
            pedidos.TabIndex = 4;
            pedidos.SelectedIndexChanged += pedidos_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(586, 142);
            button1.Name = "button1";
            button1.Size = new Size(79, 34);
            button1.TabIndex = 5;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // historico
            // 
            historico.BackColor = Color.FromArgb(17, 25, 12);
            historico.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historico.ForeColor = Color.FromArgb(230, 255, 0);
            historico.FormattingEnabled = true;
            historico.ItemHeight = 20;
            historico.Location = new Point(711, 232);
            historico.Name = "historico";
            historico.Size = new Size(358, 284);
            historico.TabIndex = 8;
            historico.SelectedIndexChanged += historico_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(12, 539);
            button2.Name = "button2";
            button2.Size = new Size(75, 49);
            button2.TabIndex = 23;
            button2.Text = "vendas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(724, 209);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 24;
            label2.Text = "Pedidos Entregues";
            // 
            // balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(1081, 600);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(historico);
            Controls.Add(button1);
            Controls.Add(pedidos);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "balcão";
            Text = "Form2";
            Load += balcão_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private ListBox pedidos;
        private Button button1;
        private ListBox historico;
        private Button button2;
        private Label label2;
    }
}