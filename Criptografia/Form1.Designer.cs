namespace Criptografia
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Btn_Minimize = new Button();
            Btn_Close = new Button();
            panel2 = new Panel();
            label1 = new Label();
            Btn_Menu = new Button();
            panel_Menu = new Panel();
            Animation_Menu = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(125, 60, 152);
            panel1.Controls.Add(Btn_Minimize);
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 21);
            panel1.TabIndex = 0;
            // 
            // Btn_Minimize
            // 
            Btn_Minimize.Dock = DockStyle.Right;
            Btn_Minimize.FlatAppearance.BorderSize = 0;
            Btn_Minimize.FlatStyle = FlatStyle.Flat;
            Btn_Minimize.Image = (Image)resources.GetObject("Btn_Minimize.Image");
            Btn_Minimize.Location = new Point(730, 0);
            Btn_Minimize.Name = "Btn_Minimize";
            Btn_Minimize.Size = new Size(35, 21);
            Btn_Minimize.TabIndex = 2;
            Btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            Btn_Close.Dock = DockStyle.Right;
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatAppearance.MouseOverBackColor = Color.Red;
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Image = (Image)resources.GetObject("Btn_Close.Image");
            Btn_Close.Location = new Point(765, 0);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(35, 21);
            Btn_Close.TabIndex = 1;
            Btn_Close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(160, 100, 190);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Btn_Menu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 42);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 3;
            label1.Text = "Criptografia";
            // 
            // Btn_Menu
            // 
            Btn_Menu.Dock = DockStyle.Left;
            Btn_Menu.FlatAppearance.BorderSize = 0;
            Btn_Menu.FlatStyle = FlatStyle.Flat;
            Btn_Menu.Image = (Image)resources.GetObject("Btn_Menu.Image");
            Btn_Menu.Location = new Point(0, 0);
            Btn_Menu.Name = "Btn_Menu";
            Btn_Menu.Size = new Size(46, 42);
            Btn_Menu.TabIndex = 0;
            Btn_Menu.UseVisualStyleBackColor = true;
            Btn_Menu.Click += Btn_Menu_Click;
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.FromArgb(125, 60, 152);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 63);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(198, 387);
            panel_Menu.TabIndex = 2;
            // 
            // Animation_Menu
            // 
            Animation_Menu.Interval = 10;
            Animation_Menu.Tick += Animation_Menu_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Menu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Btn_Menu;
        private Panel panel_Menu;
        private System.Windows.Forms.Timer Animation_Menu;
        private Button Btn_Close;
        private Button Btn_Minimize;
        private Label label1;
    }
}
