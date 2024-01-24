using Criptografia.Modules.Gerenciar_Arquivos;
using Criptografia.Modules.CriptoFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Criptografia.Pages.Descriptografia
{
    public partial class F_Aes_Descriptografia : Form
    {
        public F_Aes_Descriptografia()
        {
            InitializeComponent();
        }


        #region // Events

        #region // page Arquivo  

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                diretory = openFileDialog1.FileName;
                Tb_Diretory.Text = diretory;
                Decript = null;
                data = ReadFile.GetBytes(diretory);
            }
        }

        private void Btn_CriptografarFile_Click(object sender, EventArgs e)
        {
            try
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

                Decript = aes.DescriptografarArquivos(Mtb_Password.Text, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            if (Decript != null)
            {
                string extension = Path.GetExtension((diretory).Replace(".aes", ""));
                saveFileDialog1.InitialDirectory = diretory;
                saveFileDialog1.Filter = $"Arquivos De criptografia | *{extension}";
                saveFileDialog1.Title = "Salvar arquivo Criptografado";


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CreateFile.CopyFile(Decript, saveFileDialog1.FileName);
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



        #region // page texto

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
            byte[] byteArray = Convert.FromBase64String(Tb_Texto.Text);
            Tb_Texto.Text = aes.DesCriptografarString(Mtb_Password.Text, byteArray);
        }



        #endregion



        #endregion



        string diretory;
        byte[] data;
        byte[] Decript;

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
