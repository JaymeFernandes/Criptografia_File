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
            panel6 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            Animation_Menu = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_Menu.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
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
            panel_Menu.Controls.Add(panel6);
            panel_Menu.Controls.Add(button2);
            panel_Menu.Controls.Add(panel5);
            panel_Menu.Controls.Add(button1);
            panel_Menu.Controls.Add(panel4);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 63);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(198, 387);
            panel_Menu.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(160, 100, 190);
            panel6.Controls.Add(button3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 204);
            panel6.Name = "panel6";
            panel6.Size = new Size(198, 42);
            panel6.TabIndex = 4;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(198, 42);
            button3.TabIndex = 0;
            button3.Text = "Aes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 159);
            button2.Name = "button2";
            button2.Size = new Size(198, 45);
            button2.TabIndex = 2;
            button2.Text = "Descriptografar";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(160, 100, 190);
            panel5.Controls.Add(button4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 42);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(198, 42);
            button4.TabIndex = 1;
            button4.Text = "Aes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 72);
            button1.Name = "button1";
            button1.Size = new Size(198, 45);
            button1.TabIndex = 1;
            button1.Text = "Criptografar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 72);
            panel4.TabIndex = 0;
            // 
            // Animation_Menu
            // 
            Animation_Menu.Interval = 5;
            Animation_Menu.Tick += Animation_Menu_Tick;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 387);
            panel3.TabIndex = 3;
            // 
            // button6
            // 
            button6.Location = new Point(413, 127);
            button6.Name = "button6";
            button6.Size = new Size(124, 23);
            button6.TabIndex = 4;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(307, 127);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(360, 175);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
            label2.TabIndex = 0;
            label2.Text = "Inicio";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Menu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_Menu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button button3;
        private Panel panel6;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
    }
}
