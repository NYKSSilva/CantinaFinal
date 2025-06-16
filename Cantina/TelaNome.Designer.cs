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
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Agrandir", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nome.Location = new Point(397, 246);
            nome.Name = "nome";
            nome.Size = new Size(94, 39);
            nome.TabIndex = 0;
            nome.Text = "label1";
            // 
            // TelaNome
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(942, 543);
            Controls.Add(nome);
            Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "TelaNome";
            Text = "TelaNome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nome;
    }
}