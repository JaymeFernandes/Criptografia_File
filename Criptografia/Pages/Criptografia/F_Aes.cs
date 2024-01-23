using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptografia.Modules.CriptoFile;
using Criptografia.Modules.Gerenciar_Arquivos;

namespace Criptografia.Pages.Criptografia
{
    public partial class F_Aes : Form
    {
        public F_Aes()
        {
            InitializeComponent();
        }

        #region Events


        #region //Page Arquivo

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                diretory = openFileDialog1.FileName;
                Tb_Diretory.Text = diretory;
                Cript = null;
                data = ReadFile.GetBytes(diretory);
            }
        }

        private void Btn_CriptografarFile_Click(object sender, EventArgs e)
        {
            if (Mtb_Password.Text.Length < 5)
            {
                MessageBox.Show("Necesita de uma senha para efetuar a criptografia de no minimo 5 caracteres");
                Mtb_Password.Focus();
                return;
            }
            else if (Tb_Diretory == null || data == null)
            {
                MessageBox.Show("Selecione um arquivo para a criptografia");
                Btn_OpenFile.Focus();
                return;
            }

            Aes aes = new Aes();

            Cript = aes.CriptografarArquivos(Mtb_Password.Text, data);
        }

        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            if (Cript != null)
            {
                string estensão = Path.GetExtension(diretory);

                saveFileDialog1.InitialDirectory = diretory;
                saveFileDialog1.Filter = $"Arquivos De criptografia | *{estensão}.aes";
                saveFileDialog1.Title = "Salvar arquivo Criptografado";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CreateFile.CopyFile(Cript, saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Necessita criptografar um arquivo para salvar");
                return;
            }
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            if (Mtb_Password.PasswordChar == '*')
            {
                Mtb_Password.PasswordChar = '\0';
            }
            else
            {
                Mtb_Password.PasswordChar = '*';
            }
        }

        #endregion


        #region //Page Texto

        private void Btn_Criptografar_Page2_Click(object sender, EventArgs e)
        {
            if (Mtb_Password_page2.Text.Length < 5)
            {
                MessageBox.Show("Necesita de uma senha para a criptografia de no minimo 5 caracteres");
                Mtb_Password.Focus();
                return;
            }
            else if (Tb_Texto.Text.Length == 0)
            {
                MessageBox.Show("Necessita de um texto para a criptografia");
                Tb_Texto.Focus();
                return;
            }

            Aes aes = new Aes();
            byte[] temp = aes.CriptografarString(Mtb_Password.Text, Tb_Texto.Text);
            Tb_Texto.Text = Convert.ToBase64String(temp);
        }

        #endregion


        #endregion


        string diretory;
        byte[] data;
        byte[] Cript;

        private void Btn_Senha_Page2_Click(object sender, EventArgs e)
        {
            if (Mtb_Password_page2.PasswordChar == '*')
            {
                Mtb_Password_page2.PasswordChar = '\0';
            }
            else
            {
                Mtb_Password_page2.PasswordChar = '*';
            }
        }
    }
}
