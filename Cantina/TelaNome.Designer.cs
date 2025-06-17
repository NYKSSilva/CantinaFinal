namespace Cantina
{
    partial class TelaNome
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
            nome = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Agrandir", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nome.Location = new Point(367, 251);
            nome.Name = "nome";
            nome.Size = new Size(121, 50);
            nome.TabIndex = 0;
            nome.Text = "label1";
            nome.Click += nome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 172);
            label1.Name = "label1";
            label1.Size = new Size(200, 39);
            label1.TabIndex = 1;
            label1.Text = "Pedido Pronto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio;
            pictureBox2.Location = new Point(-41, -49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(923, 639);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // TelaNome
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(942, 543);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(nome);
            Controls.Add(pictureBox2);
            Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "TelaNome";
            Text = "TelaNome";
            Load += TelaNome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nome;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}