namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region //Events

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Animation_Menu.Start();
        }

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
    }
}
