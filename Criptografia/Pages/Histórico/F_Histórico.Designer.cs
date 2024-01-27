namespace Criptografia.Pages.Histórico
{
    partial class F_Histórico
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
            label1 = new Label();
            P_Vill = new Panel();
            panel4 = new Panel();
            P_Contorno = new Panel();
            P_Vill.SuspendLayout();
            P_Contorno.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 2;
            label1.Text = "Hístorico de Criptografia";
            // 
            // P_Vill
            // 
            P_Vill.AutoScroll = true;
            P_Vill.BackColor = Color.Black;
            P_Vill.Controls.Add(panel4);
            P_Vill.Location = new Point(3, 3);
            P_Vill.Name = "P_Vill";
            P_Vill.Size = new Size(613, 337);
            P_Vill.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(613, 1);
            panel4.TabIndex = 7;
            // 
            // P_Contorno
            // 
            P_Contorno.BackColor = Color.White;
            P_Contorno.Controls.Add(P_Vill);
            P_Contorno.Location = new Point(17, 79);
            P_Contorno.Name = "P_Contorno";
            P_Contorno.Size = new Size(619, 343);
            P_Contorno.TabIndex = 6;
            // 
            // F_Histórico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 12, 26);
            ClientSize = new Size(653, 445);
            Controls.Add(label1);
            Controls.Add(P_Contorno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Histórico";
            Text = "F_Histórico";
            P_Vill.ResumeLayout(false);
            P_Contorno.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel P_Vill;
        private Panel P_Contorno;
        private Panel panel4;
    }
}