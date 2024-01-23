using Criptografia.Modules.CriptoFile;
using Criptografia.Modules.Gerenciar_Arquivos;
using Criptografia.Pages.Criptografia;
using System.Text;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;

namespace Criptografia
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        #region Pages

        private void ClosePage()
        {
            if (PageSelect != null)
            {
                PageSelect.Close();
            }
        }

        private void LoadingPage(Form Page)
        {
            ClosePage();

            Page.Dock = DockStyle.Fill;
            Page.TopLevel = false;
            this.panelMain.Controls.Add(Page);
            this.panelMain.Tag = Page;
            Page.Show();
        }

        #endregion

        #region //Events

        #region // Componentes
        //fecha a aplicação
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Criptografia_Click(object sender, EventArgs e)
        {
            Animation_SubMenu_Criptografia.Start();
        }

        private void Btn_Descriptografia_Click(object sender, EventArgs e)
        {
            Animation_SubMenu_Descriptografia.Start();
        }

        private void Panel_Borderless_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region // Animations
        //animação de abrir e fechar o menu
        private void Animation_SubMenu_Criptografia_Tick(object sender, EventArgs e)
        {
            if (Menu_Criptografia)
            {
                panel_SubMenu_Criptografia.Height = (panel_SubMenu_Criptografia.Height - 10 >= 0
                    ? panel_SubMenu_Criptografia.Height - 10 : 0);
            }
            else
            {
                panel_SubMenu_Criptografia.Height = (panel_SubMenu_Criptografia.Height + 10 <= 36
                    ? panel_SubMenu_Criptografia.Height + 10 : 36);
            }

            if (panel_SubMenu_Criptografia.Height == (Menu_Criptografia ? 0 : 36))
            {
                Menu_Criptografia = !Menu_Criptografia;
                Btn_Criptografia.TextImageRelation =
                    (Menu_Criptografia ? TextImageRelation.TextBeforeImage : TextImageRelation.ImageBeforeText);
                Animation_SubMenu_Criptografia.Stop();
            }
        }

        private void Animation_SubMenu_Descriptografia_Tick(object sender, EventArgs e)
        {
            if (Menu_Descriptografia)
            {
                panel_SubMenu_Descriptografia.Height = (panel_SubMenu_Descriptografia.Height - 10 >= 0
                    ? panel_SubMenu_Descriptografia.Height - 10 : 0);
            }
            else
            {
                panel_SubMenu_Descriptografia.Height = (panel_SubMenu_Descriptografia.Height + 10 <= 36
                    ? panel_SubMenu_Descriptografia.Height + 10 : 36);
            }

            if (panel_SubMenu_Descriptografia.Height == (Menu_Descriptografia ? 0 : 36))
            {
                Menu_Descriptografia = !Menu_Descriptografia;
                Btn_Descriptografia.TextImageRelation =
                    (Menu_Descriptografia ? TextImageRelation.TextBeforeImage : TextImageRelation.ImageBeforeText);
                Animation_SubMenu_Descriptografia.Stop();
            }
        }

        #endregion

        #endregion



        //Variavel que guarda se o menu está aberto
        bool Menu_Criptografia = false;
        bool Menu_Descriptografia = true;
        Form PageSelect;



        // Dlls imports
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void Btn_Criptografia_Aes_Click(object sender, EventArgs e)
        {
            LoadingPage(new F_Aes());
        }
    }
}
