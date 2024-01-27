// Importando namespaces necessários
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
using Criptografia.Pages.Histórico;

namespace Criptografia.Pages.Criptografia
{
    /// <summary>
    /// Classe que representa a página de criptografia AES.
    /// </summary>
    public partial class F_Aes_Criptografia : Form
    {
        #region Variáveis

        private string diretory;
        private byte[] data;
        private byte[] Cript;

        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="F_Aes_Criptografia"/>.
        /// </summary>
        public F_Aes_Criptografia()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Exibe uma mensagem de erro em uma caixa de diálogo.
        /// </summary>
        /// <param name="message">Mensagem de erro a ser exibida.</param>
        private void ExibirErro(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region //Page Arquivo

        /// <summary>
        /// Manipula o clique no botão para abrir um arquivo.
        /// </summary>
        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    diretory = openFileDialog1.FileName;
                    Tb_Diretory.Text = diretory;
                    Cript = null;
                    data = ArquivoHandler.LerArquivoByte(diretory);

                    List<CryptHistoryEntry> list = new List<CryptHistoryEntry>();

                    if (File.Exists(@"Modules/Historico.json"))
                    {
                        string json = ArquivoHandler.LerArquivo(@"Modules/Historico.json");

                        list = JSON.ConvertObject<CryptHistoryEntry>(json);

                    }

                    CryptHistoryEntry file = new CryptHistoryEntry();
                    file.name = Path.GetFileName(diretory);
                    file.pathFile = diretory;
                    file.date = DateTime.Now;
                    file.TypeCript = "Criptografia - AES";
                    list.Add(file);

                    ArquivoHandler.EscreverArquivo(JSON.ConvertJson<CryptHistoryEntry>(list), "Modules/Historico.json");
                }
            }
            catch (Exception ex)
            {
                ExibirErro(ex.Message);
            }
        }

        /// <summary>
        /// Manipula o clique no botão para criptografar um arquivo.
        /// </summary>
        private void Btn_CriptografarFile_Click(object sender, EventArgs e)
        {
            if (Mtb_Password.Text.Length < 5)
            {
                ExibirErro("Necesita de uma senha para efetuar a criptografia de no mínimo 5 caracteres");
                Mtb_Password.Focus();
                return;
            }
            else if (Tb_Diretory.Text == string.Empty || data == null)
            {
                ExibirErro("Selecione um arquivo para a criptografia");
                Btn_OpenFile.Focus();
                return;
            }

            Aes aes = new Aes();

            Cript = aes.CriptografarArquivos(Mtb_Password.Text, data);
        }

        /// <summary>
        /// Manipula o clique no botão para salvar o arquivo criptografado.
        /// </summary>
        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            if (Cript != null)
            {
                string extensao = Path.GetExtension(diretory);

                saveFileDialog1.InitialDirectory = diretory;
                saveFileDialog1.Filter = $"Arquivos De criptografia | *{extensao}.aes";
                saveFileDialog1.Title = "Salvar arquivo Criptografado";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ArquivoHandler.EscreverArquivo(Cript, saveFileDialog1.FileName);
                }
            }
            else
            {
                ExibirErro("Necessita criptografar um arquivo para salvar");
            }
        }

        /// <summary>
        /// Manipula o clique no botão para exibir ou ocultar a senha.
        /// </summary>
        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Mtb_Password.PasswordChar = (Mtb_Password.PasswordChar == 0 ? '*' : '\0');
        }

        #endregion


        #region //Page Texto

        /// <summary>
        /// Manipula o clique no botão para criptografar um texto.
        /// </summary>
        private void Btn_Criptografar_Page2_Click(object sender, EventArgs e)
        {
            if (Mtb_Password_page2.Text.Length < 5)
            {
                ExibirErro("Necesita de uma senha para a criptografia de no mínimo 5 caracteres");
                Mtb_Password.Focus();
                return;
            }
            else if (Tb_Texto.Text.Length == 0)
            {
                ExibirErro("Necessita de um texto para a criptografia");
                Tb_Texto.Focus();
                return;
            }

            Aes aes = new Aes();
            byte[] temp = aes.CriptografarString(Mtb_Password.Text, Tb_Texto.Text);
            Tb_Texto.Text = Convert.ToBase64String(temp);
        }

        /// <summary>
        /// Manipula o clique no botão para exibir ou ocultar a senha do texto.
        /// </summary>
        private void Btn_Senha_Page2_Click(object sender, EventArgs e)
        {
            Mtb_Password_page2.PasswordChar = (Mtb_Password_page2.PasswordChar == 0 ? '*' : '\0');
        }

        #endregion


        #endregion
    }
}
