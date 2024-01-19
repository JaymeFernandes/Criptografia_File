using Criptografia.CriptoFile;
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
            Aes aes = new Aes();
            test1 = aes.CriptografarString(textBox2.Text, textBox1.Text);
            textBox1.Text = Convert.ToBase64String(test1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aes aes = new Aes();
            byte[] bytes = test1;

            textBox1.Text = aes.DesCriptografarString(textBox2.Text, test1);
        }

        byte[] test1;
    }
}
