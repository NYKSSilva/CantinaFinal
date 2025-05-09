namespace Cantina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pedido = new ListBox();
            Menu = new ListBox();
            button1 = new Button();
            button2 = new Button();
            lblMostradorDeTotal = new Label();
            button3 = new Button();
            label2 = new Label();
            lblTotal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pedido
            // 
            Pedido.BackColor = Color.Honeydew;
            Pedido.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedido.FormattingEnabled = true;
            Pedido.ItemHeight = 25;
            Pedido.Location = new Point(753, 200);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(316, 154);
            Pedido.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.Honeydew;
            Menu.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu.FormattingEnabled = true;
            Menu.ItemHeight = 24;
            Menu.Items.AddRange(new object[] { "" });
            Menu.Location = new Point(29, 200);
            Menu.Name = "Menu";
            Menu.Size = new Size(304, 172);
            Menu.TabIndex = 1;
            Menu.SelectedIndexChanged += Menu_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(216, 413);
            button1.Name = "button1";
            button1.Size = new Size(348, 49);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(619, 413);
            button2.Name = "button2";
            button2.Size = new Size(348, 49);
            button2.TabIndex = 3;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblMostradorDeTotal
            // 
            lblMostradorDeTotal.AutoSize = true;
            lblMostradorDeTotal.BackColor = Color.Honeydew;
            lblMostradorDeTotal.Font = new Font("Century Schoolbook", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostradorDeTotal.Location = new Point(346, 504);
            lblMostradorDeTotal.Name = "lblMostradorDeTotal";
            lblMostradorDeTotal.Size = new Size(218, 55);
            lblMostradorDeTotal.TabIndex = 5;
            lblMostradorDeTotal.Text = "TOTAL:";
            lblMostradorDeTotal.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(428, 267);
            button3.Name = "button3";
            button3.Size = new Size(262, 49);
            button3.TabIndex = 6;
            button3.Text = "FECHAR PEDIDO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            lblTotal.BackColor = Color.Honeydew;
            lblTotal.Font = new Font("Century Schoolbook", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(619, 504);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 55);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label3";
            lblTotal.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(583, -49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 758);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 672);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(lblMostradorDeTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Menu);
            Controls.Add(Pedido);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Cantina";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pedido;
        private ListBox Menu;
        private Button button1;
        private Button button2;
        private Label lblMostradorDeTotal;
        private Button button3;
        private Label label2;
        private Label lblTotal;
        private PictureBox pictureBox1;
    }
}
