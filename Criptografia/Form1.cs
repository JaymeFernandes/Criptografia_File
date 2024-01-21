using Criptografia.Modules.CriptoFile;
using Criptografia.Modules.Gerenciar_Arquivos;
using System.Text;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region //Events

        //fecha a aplicação
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Button Menu
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Animation_Menu.Start();
        }

        //animação de abrir e fechar o menu
        private void Animation_Menu_Tick(object sender, EventArgs e)
        {
            // verifica se o menu está aberto e coloca na proporção correta
            if (Menu)
            {
                panel_Menu.Width = (panel_Menu.Width - 10 >= 0 ? panel_Menu.Width - 10 : 0);
            }
            else
            {
                panel_Menu.Width = (panel_Menu.Width + 10 <= 198 ? panel_Menu.Width + 10 : 198);
            }

            //inverte o status do Menu e para a operação
            if (panel_Menu.Width == (Menu ? 0 : 198))
            {
                Menu = !Menu;
                Animation_Menu.Stop();
            }
        }

        #endregion

        //Variavel que guarda se o menu está aberto
        bool Menu = true;

        private void button5_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                Dados = ReadFile.GetBytes(openFileDialog1.FileName);
                Pathfile = openFileDialog1.FileName;
            }
        }

        byte[] Dados;
        string Pathfile;

        private void button6_Click(object sender, EventArgs e)
        {
            Aes aes = new Aes();

            byte[] cript = aes.CriptografarArquivos(textBox1.Text, Dados);

            CreateFile.CopyFile(cript, Pathfile, "aes");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Aes aes = new Aes();

            byte[] cript = aes.DescriptografarArquivos(textBox1.Text, Dados);
            Pathfile = Pathfile.Replace(".aes", "");
            CreateFile.CopyFile(cript, Pathfile, "");
        }
    }
}
