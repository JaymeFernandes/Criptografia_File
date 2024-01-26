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
            panelVill = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panelVill.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 2;
            label1.Text = "Hístorico de Criptografia";
            // 
            // panelVill
            // 
            panelVill.AutoScroll = true;
            panelVill.BackColor = Color.Black;
            panelVill.Controls.Add(panel4);
            panelVill.Controls.Add(panel1);
            panelVill.Location = new Point(3, 3);
            panelVill.Name = "panelVill";
            panelVill.Size = new Size(596, 256);
            panelVill.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 1);
            panel4.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 12, 26);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 69);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 24);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 10;
            label5.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(375, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 9;
            label4.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 45);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 8;
            label3.Text = "Local:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 7;
            label2.Text = "Nome: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Purple;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 69);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panelVill);
            panel3.Location = new Point(22, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 262);
            panel3.TabIndex = 6;
            // 
            // F_Histórico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 12, 26);
            ClientSize = new Size(653, 445);
            Controls.Add(label1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Histórico";
            Text = "F_Histórico";
            panelVill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelVill;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}