namespace Criptografia
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            Panel_Borderless = new Panel();
            Btn_Minimize = new Button();
            Btn_Close = new Button();
            panel_Menu = new Panel();
            Btn_Historico = new Button();
            panel_SubMenu_Descriptografia = new Panel();
            bnt_Descriptografia_Aes = new Button();
            panel5 = new Panel();
            Btn_Descriptografia = new Button();
            panel_SubMenu_Criptografia = new Panel();
            Btn_Criptografia_Aes = new Button();
            panel3 = new Panel();
            Btn_Criptografia = new Button();
            panel1 = new Panel();
            Animation_SubMenu_Criptografia = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            openFileDialog1 = new OpenFileDialog();
            Animation_SubMenu_Descriptografia = new System.Windows.Forms.Timer(components);
            Panel_Borderless.SuspendLayout();
            panel_Menu.SuspendLayout();
            panel_SubMenu_Descriptografia.SuspendLayout();
            panel_SubMenu_Criptografia.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Borderless
            // 
            resources.ApplyResources(Panel_Borderless, "Panel_Borderless");
            Panel_Borderless.BackColor = Color.FromArgb(5, 12, 26);
            Panel_Borderless.Controls.Add(Btn_Minimize);
            Panel_Borderless.Controls.Add(Btn_Close);
            Panel_Borderless.Name = "Panel_Borderless";
            Panel_Borderless.MouseDown += Panel_Borderless_MouseDown;
            // 
            // Btn_Minimize
            // 
            resources.ApplyResources(Btn_Minimize, "Btn_Minimize");
            Btn_Minimize.FlatAppearance.BorderSize = 0;
            Btn_Minimize.Name = "Btn_Minimize";
            Btn_Minimize.UseVisualStyleBackColor = true;
            Btn_Minimize.Click += Btn_Minimize_Click;
            // 
            // Btn_Close
            // 
            resources.ApplyResources(Btn_Close, "Btn_Close");
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatAppearance.MouseOverBackColor = Color.Red;
            Btn_Close.Name = "Btn_Close";
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // panel_Menu
            // 
            resources.ApplyResources(panel_Menu, "panel_Menu");
            panel_Menu.BackColor = Color.FromArgb(5, 12, 59);
            panel_Menu.Controls.Add(Btn_Historico);
            panel_Menu.Controls.Add(panel_SubMenu_Descriptografia);
            panel_Menu.Controls.Add(Btn_Descriptografia);
            panel_Menu.Controls.Add(panel_SubMenu_Criptografia);
            panel_Menu.Controls.Add(Btn_Criptografia);
            panel_Menu.Controls.Add(panel1);
            panel_Menu.Name = "panel_Menu";
            // 
            // Btn_Historico
            // 
            resources.ApplyResources(Btn_Historico, "Btn_Historico");
            Btn_Historico.Cursor = Cursors.Hand;
            Btn_Historico.FlatAppearance.BorderSize = 0;
            Btn_Historico.ForeColor = Color.White;
            Btn_Historico.Name = "Btn_Historico";
            Btn_Historico.UseVisualStyleBackColor = true;
            Btn_Historico.Click += Btn_Historico_Click;
            // 
            // panel_SubMenu_Descriptografia
            // 
            resources.ApplyResources(panel_SubMenu_Descriptografia, "panel_SubMenu_Descriptografia");
            panel_SubMenu_Descriptografia.Controls.Add(bnt_Descriptografia_Aes);
            panel_SubMenu_Descriptografia.Controls.Add(panel5);
            panel_SubMenu_Descriptografia.Name = "panel_SubMenu_Descriptografia";
            // 
            // bnt_Descriptografia_Aes
            // 
            resources.ApplyResources(bnt_Descriptografia_Aes, "bnt_Descriptografia_Aes");
            bnt_Descriptografia_Aes.Cursor = Cursors.Hand;
            bnt_Descriptografia_Aes.FlatAppearance.BorderSize = 0;
            bnt_Descriptografia_Aes.ForeColor = Color.White;
            bnt_Descriptografia_Aes.Name = "bnt_Descriptografia_Aes";
            bnt_Descriptografia_Aes.UseVisualStyleBackColor = true;
            bnt_Descriptografia_Aes.Click += bnt_Descriptografia_Aes_Click;
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.BackColor = Color.MediumSlateBlue;
            panel5.Name = "panel5";
            // 
            // Btn_Descriptografia
            // 
            resources.ApplyResources(Btn_Descriptografia, "Btn_Descriptografia");
            Btn_Descriptografia.Cursor = Cursors.Hand;
            Btn_Descriptografia.FlatAppearance.BorderSize = 0;
            Btn_Descriptografia.ForeColor = Color.White;
            Btn_Descriptografia.Name = "Btn_Descriptografia";
            Btn_Descriptografia.UseVisualStyleBackColor = true;
            Btn_Descriptografia.Click += Btn_Descriptografia_Click;
            // 
            // panel_SubMenu_Criptografia
            // 
            resources.ApplyResources(panel_SubMenu_Criptografia, "panel_SubMenu_Criptografia");
            panel_SubMenu_Criptografia.Controls.Add(Btn_Criptografia_Aes);
            panel_SubMenu_Criptografia.Controls.Add(panel3);
            panel_SubMenu_Criptografia.Name = "panel_SubMenu_Criptografia";
            // 
            // Btn_Criptografia_Aes
            // 
            resources.ApplyResources(Btn_Criptografia_Aes, "Btn_Criptografia_Aes");
            Btn_Criptografia_Aes.Cursor = Cursors.Hand;
            Btn_Criptografia_Aes.FlatAppearance.BorderSize = 0;
            Btn_Criptografia_Aes.ForeColor = Color.White;
            Btn_Criptografia_Aes.Name = "Btn_Criptografia_Aes";
            Btn_Criptografia_Aes.UseVisualStyleBackColor = true;
            Btn_Criptografia_Aes.Click += Btn_Criptografia_Aes_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Name = "panel3";
            // 
            // Btn_Criptografia
            // 
            resources.ApplyResources(Btn_Criptografia, "Btn_Criptografia");
            Btn_Criptografia.Cursor = Cursors.Hand;
            Btn_Criptografia.FlatAppearance.BorderSize = 0;
            Btn_Criptografia.ForeColor = Color.White;
            Btn_Criptografia.Name = "Btn_Criptografia";
            Btn_Criptografia.UseVisualStyleBackColor = true;
            Btn_Criptografia.Click += Btn_Criptografia_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // Animation_SubMenu_Criptografia
            // 
            Animation_SubMenu_Criptografia.Interval = 5;
            Animation_SubMenu_Criptografia.Tick += Animation_SubMenu_Criptografia_Tick;
            // 
            // panelMain
            // 
            resources.ApplyResources(panelMain, "panelMain");
            panelMain.BackColor = Color.FromArgb(5, 12, 26);
            panelMain.Name = "panelMain";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(openFileDialog1, "openFileDialog1");
            // 
            // Animation_SubMenu_Descriptografia
            // 
            Animation_SubMenu_Descriptografia.Interval = 1;
            Animation_SubMenu_Descriptografia.Tick += Animation_SubMenu_Descriptografia_Tick;
            // 
            // Form_Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_Borderless);
            Controls.Add(panelMain);
            Controls.Add(panel_Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Main";
            Panel_Borderless.ResumeLayout(false);
            panel_Menu.ResumeLayout(false);
            panel_SubMenu_Descriptografia.ResumeLayout(false);
            panel_SubMenu_Criptografia.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Menu;
        private System.Windows.Forms.Timer Animation_SubMenu_Criptografia;
        private Button Btn_Close;
        private Button Btn_Minimize;
        private Panel panelMain;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button Btn_Criptografia;
        private Panel panel_SubMenu_Criptografia;
        private Panel panel3;
        private Button Btn_Criptografia_Aes;
        private Button Btn_Descriptografia;
        private Panel panel_SubMenu_Descriptografia;
        private Button bnt_Descriptografia_Aes;
        private Panel panel5;
        private Button Btn_Historico;
        private System.Windows.Forms.Timer Animation_SubMenu_Descriptografia;
        public Panel Panel_Borderless;
    }
}
