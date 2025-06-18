namespace Cantina
{
    partial class Chamada
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
            Pronto = new ListBox();
            button1 = new Button();
            button2 = new Button();
            Andamento = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pronto
            // 
            Pronto.BackColor = Color.Black;
            Pronto.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pronto.ForeColor = Color.FromArgb(230, 255, 0);
            Pronto.FormattingEnabled = true;
            Pronto.ItemHeight = 21;
            Pronto.Location = new Point(530, 141);
            Pronto.Name = "Pronto";
            Pronto.Size = new Size(268, 361);
            Pronto.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(917, 391);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 1;
            button1.Text = "Vendas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(917, 449);
            button2.Name = "button2";
            button2.Size = new Size(87, 34);
            button2.TabIndex = 2;
            button2.Text = "Balcão";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Andamento
            // 
            Andamento.BackColor = Color.FromArgb(230, 255, 0);
            Andamento.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Andamento.ForeColor = Color.Black;
            Andamento.FormattingEnabled = true;
            Andamento.ItemHeight = 21;
            Andamento.Location = new Point(167, 53);
            Andamento.Name = "Andamento";
            Andamento.Size = new Size(268, 361);
            Andamento.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-33, -75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(923, 639);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(879, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 8;
            label1.Text = "Preparando";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(617, 117);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 9;
            label2.Text = "Pronto";
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(1029, 524);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Andamento);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pronto);
            Controls.Add(pictureBox2);
            Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pronto;
        private Button button1;
        private Button button2;
        private ListBox Andamento;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}