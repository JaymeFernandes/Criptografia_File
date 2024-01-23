namespace Criptografia.Pages.Criptografia
{
    partial class F_Aes
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
            panel1 = new Panel();
            Tc_Main = new TabControl();
            Tp_File = new TabPage();
            Btn_Senha = new Button();
            Mtb_Password = new MaskedTextBox();
            label3 = new Label();
            Btn_SaveFile = new Button();
            Btn_CriptografarFile = new Button();
            label2 = new Label();
            Btn_OpenFile = new Button();
            Tb_Diretory = new TextBox();
            Tp_String = new TabPage();
            label5 = new Label();
            label4 = new Label();
            Btn_Senha_Page2 = new Button();
            Btn_Criptografar_Page2 = new Button();
            Mtb_Password_page2 = new MaskedTextBox();
            Tb_Texto = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            Tc_Main.SuspendLayout();
            Tp_File.SuspendLayout();
            Tp_String.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Tc_Main);
            panel1.Location = new Point(56, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 313);
            panel1.TabIndex = 0;
            // 
            // Tc_Main
            // 
            Tc_Main.Controls.Add(Tp_File);
            Tc_Main.Controls.Add(Tp_String);
            Tc_Main.Dock = DockStyle.Fill;
            Tc_Main.Location = new Point(0, 0);
            Tc_Main.Multiline = true;
            Tc_Main.Name = "Tc_Main";
            Tc_Main.SelectedIndex = 0;
            Tc_Main.Size = new Size(574, 313);
            Tc_Main.SizeMode = TabSizeMode.Fixed;
            Tc_Main.TabIndex = 0;
            // 
            // Tp_File
            // 
            Tp_File.BackColor = Color.FromArgb(5, 12, 26);
            Tp_File.Controls.Add(Btn_Senha);
            Tp_File.Controls.Add(Mtb_Password);
            Tp_File.Controls.Add(label3);
            Tp_File.Controls.Add(Btn_SaveFile);
            Tp_File.Controls.Add(Btn_CriptografarFile);
            Tp_File.Controls.Add(label2);
            Tp_File.Controls.Add(Btn_OpenFile);
            Tp_File.Controls.Add(Tb_Diretory);
            Tp_File.ForeColor = SystemColors.ControlText;
            Tp_File.Location = new Point(4, 24);
            Tp_File.Name = "Tp_File";
            Tp_File.Padding = new Padding(3);
            Tp_File.Size = new Size(566, 285);
            Tp_File.TabIndex = 0;
            Tp_File.Text = "Arquivo";
            // 
            // Btn_Senha
            // 
            Btn_Senha.BackColor = Color.Purple;
            Btn_Senha.FlatAppearance.BorderSize = 0;
            Btn_Senha.FlatStyle = FlatStyle.Flat;
            Btn_Senha.ForeColor = Color.White;
            Btn_Senha.Location = new Point(191, 100);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(74, 23);
            Btn_Senha.TabIndex = 10;
            Btn_Senha.Text = "Ver Senha";
            Btn_Senha.UseVisualStyleBackColor = false;
            Btn_Senha.Click += Btn_Senha_Click;
            // 
            // Mtb_Password
            // 
            Mtb_Password.Location = new Point(6, 100);
            Mtb_Password.Name = "Mtb_Password";
            Mtb_Password.PasswordChar = '*';
            Mtb_Password.Size = new Size(179, 23);
            Mtb_Password.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // Btn_SaveFile
            // 
            Btn_SaveFile.BackColor = Color.Purple;
            Btn_SaveFile.FlatAppearance.BorderSize = 0;
            Btn_SaveFile.FlatStyle = FlatStyle.Flat;
            Btn_SaveFile.ForeColor = Color.White;
            Btn_SaveFile.Location = new Point(102, 157);
            Btn_SaveFile.Name = "Btn_SaveFile";
            Btn_SaveFile.Size = new Size(90, 34);
            Btn_SaveFile.TabIndex = 5;
            Btn_SaveFile.Text = "Salvar";
            Btn_SaveFile.UseVisualStyleBackColor = false;
            Btn_SaveFile.Click += Btn_SaveFile_Click;
            // 
            // Btn_CriptografarFile
            // 
            Btn_CriptografarFile.BackColor = Color.Purple;
            Btn_CriptografarFile.FlatAppearance.BorderSize = 0;
            Btn_CriptografarFile.FlatStyle = FlatStyle.Flat;
            Btn_CriptografarFile.ForeColor = Color.White;
            Btn_CriptografarFile.Location = new Point(6, 157);
            Btn_CriptografarFile.Name = "Btn_CriptografarFile";
            Btn_CriptografarFile.Size = new Size(90, 34);
            Btn_CriptografarFile.TabIndex = 4;
            Btn_CriptografarFile.Text = "Criptografar";
            Btn_CriptografarFile.UseVisualStyleBackColor = false;
            Btn_CriptografarFile.Click += Btn_CriptografarFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Diretório";
            // 
            // Btn_OpenFile
            // 
            Btn_OpenFile.BackColor = Color.Purple;
            Btn_OpenFile.FlatAppearance.BorderSize = 0;
            Btn_OpenFile.FlatStyle = FlatStyle.Flat;
            Btn_OpenFile.ForeColor = Color.White;
            Btn_OpenFile.Location = new Point(470, 40);
            Btn_OpenFile.Name = "Btn_OpenFile";
            Btn_OpenFile.Size = new Size(72, 23);
            Btn_OpenFile.TabIndex = 1;
            Btn_OpenFile.Text = "Abrir";
            Btn_OpenFile.UseVisualStyleBackColor = false;
            Btn_OpenFile.Click += Btn_OpenFile_Click;
            // 
            // Tb_Diretory
            // 
            Tb_Diretory.BorderStyle = BorderStyle.FixedSingle;
            Tb_Diretory.Location = new Point(6, 40);
            Tb_Diretory.Name = "Tb_Diretory";
            Tb_Diretory.ReadOnly = true;
            Tb_Diretory.Size = new Size(458, 23);
            Tb_Diretory.TabIndex = 0;
            // 
            // Tp_String
            // 
            Tp_String.BackColor = Color.FromArgb(5, 12, 26);
            Tp_String.Controls.Add(label5);
            Tp_String.Controls.Add(label4);
            Tp_String.Controls.Add(Btn_Senha_Page2);
            Tp_String.Controls.Add(Btn_Criptografar_Page2);
            Tp_String.Controls.Add(Mtb_Password_page2);
            Tp_String.Controls.Add(Tb_Texto);
            Tp_String.ForeColor = Color.Black;
            Tp_String.Location = new Point(4, 24);
            Tp_String.Name = "Tp_String";
            Tp_String.Padding = new Padding(3);
            Tp_String.Size = new Size(566, 285);
            Tp_String.TabIndex = 1;
            Tp_String.Text = "Texto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 3);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 13;
            label5.Text = "Texto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 130);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 12;
            label4.Text = "Senha";
            // 
            // Btn_Senha_Page2
            // 
            Btn_Senha_Page2.BackColor = Color.Purple;
            Btn_Senha_Page2.FlatAppearance.BorderSize = 0;
            Btn_Senha_Page2.FlatStyle = FlatStyle.Flat;
            Btn_Senha_Page2.ForeColor = Color.White;
            Btn_Senha_Page2.Location = new Point(317, 150);
            Btn_Senha_Page2.Name = "Btn_Senha_Page2";
            Btn_Senha_Page2.Size = new Size(74, 23);
            Btn_Senha_Page2.TabIndex = 11;
            Btn_Senha_Page2.Text = "Ver Senha";
            Btn_Senha_Page2.UseVisualStyleBackColor = false;
            Btn_Senha_Page2.Click += Btn_Senha_Page2_Click;
            // 
            // Btn_Criptografar_Page2
            // 
            Btn_Criptografar_Page2.BackColor = Color.Purple;
            Btn_Criptografar_Page2.FlatAppearance.BorderSize = 0;
            Btn_Criptografar_Page2.FlatStyle = FlatStyle.Flat;
            Btn_Criptografar_Page2.ForeColor = Color.White;
            Btn_Criptografar_Page2.Location = new Point(49, 193);
            Btn_Criptografar_Page2.Name = "Btn_Criptografar_Page2";
            Btn_Criptografar_Page2.Size = new Size(90, 34);
            Btn_Criptografar_Page2.TabIndex = 5;
            Btn_Criptografar_Page2.Text = "Criptografar";
            Btn_Criptografar_Page2.UseVisualStyleBackColor = false;
            Btn_Criptografar_Page2.Click += Btn_Criptografar_Page2_Click;
            // 
            // Mtb_Password_page2
            // 
            Mtb_Password_page2.Location = new Point(49, 150);
            Mtb_Password_page2.Name = "Mtb_Password_page2";
            Mtb_Password_page2.PasswordChar = '*';
            Mtb_Password_page2.Size = new Size(262, 23);
            Mtb_Password_page2.TabIndex = 2;
            // 
            // Tb_Texto
            // 
            Tb_Texto.BorderStyle = BorderStyle.FixedSingle;
            Tb_Texto.Location = new Point(49, 19);
            Tb_Texto.Multiline = true;
            Tb_Texto.Name = "Tb_Texto";
            Tb_Texto.Size = new Size(458, 105);
            Tb_Texto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 59);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 1;
            label1.Text = "Criptografia - AES";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_Aes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(5, 12, 26);
            ClientSize = new Size(669, 466);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Aes";
            Text = "F_Aes";
            panel1.ResumeLayout(false);
            Tc_Main.ResumeLayout(false);
            Tp_File.ResumeLayout(false);
            Tp_File.PerformLayout();
            Tp_String.ResumeLayout(false);
            Tp_String.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TabControl Tc_Main;
        private TabPage Tp_File;
        private TabPage Tp_String;
        private Label label1;
        private Button Btn_OpenFile;
        private TextBox Tb_Diretory;
        private Label label2;
        private Button Btn_SaveFile;
        private Button Btn_CriptografarFile;
        private Button Btn_Senha;
        private MaskedTextBox Mtb_Password;
        private Label label3;
        public OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button Btn_Senha_Page2;
        private Button Btn_Criptografar_Page2;
        private MaskedTextBox Mtb_Password_page2;
        private TextBox Tb_Texto;
        private Label label5;
        private Label label4;
    }
}