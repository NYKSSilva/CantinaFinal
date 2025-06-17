namespace Cantina
{
    partial class Cozinha
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
            pedidos = new ListBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pedidos
            // 
            pedidos.BackColor = Color.Black;
            pedidos.Font = new Font("Agrandir", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidos.ForeColor = Color.FromArgb(230, 255, 0);
            pedidos.FormattingEnabled = true;
            pedidos.ItemHeight = 17;
            pedidos.Location = new Point(83, 125);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(774, 225);
            pedidos.TabIndex = 1;
            pedidos.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Agrandir", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(717, 356);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 2;
            button1.Text = "Enviar para o balcão";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Agrandir", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(717, 396);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 3;
            button2.Text = "Vendas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-33, -71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(868, 701);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Agrandir", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(230, 255, 0);
            button3.Location = new Point(717, 436);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 5;
            button3.Text = "Balcão";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(831, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(970, 593);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pedidos);
            Controls.Add(pictureBox2);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox pedidos;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}