using Criptografia.Modules.Gerenciar_Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia.Pages.Histórico
{
    public partial class F_Histórico : Form
    {
        public F_Histórico()
        {
            InitializeComponent();
            LoadingHistorico();
        }

        private void LoadingHistorico()
        {
            if (File.Exists(PathFile))
            {
                string json = AcessFile.Read(PathFile);
                Obj_historico.Clear();
                Obj_historico = JSON.ConvertObject<HistoricoObj>(json);
            }

            panelVill.Controls.Clear();
            if(Obj_historico.Count > 0)
            {
                foreach (var obj in Obj_historico)
                {
                    MessageBox.Show(obj.pathFile);
                    //Controls
                    Panel P_vill = new Panel();
                    Panel P_desing = new Panel();
                    Panel P_separador = new Panel();
                    Label L_nome = new Label();
                    Label L_local = new Label();
                    Label L_tipo = new Label();
                    Label L_data = new Label();

                    //Nome
                    L_nome.Size = new Size(300, 21);
                    L_nome.Text = $"Nome: {obj.name}";
                    L_nome.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    L_nome.ForeColor = Color.White;

                    //local
                    L_local.Size = new Size(600, 21);
                    L_local.Text = $"Local: {obj.pathFile}";
                    L_local.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    L_local.ForeColor = Color.White;

                    //tipo
                    L_tipo.Size = new Size(300, 21);
                    L_tipo.Text = $"Tipo: {obj.TypeCript}";
                    L_tipo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    L_tipo.ForeColor = Color.White;

                    //data
                    L_data.Size = new Size(300, 21);
                    L_data.Text = $"Data: {obj.date.ToString()}";
                    L_data.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    L_data.ForeColor = Color.White;

                    //config location labels
                    L_nome.Size = new Size(300, 21);
                    L_nome.Location = new Point(24, 0);
                    L_local.Location = new Point(24, 45);
                    L_tipo.Location = new Point(375, 0);
                    L_data.Location = new Point(24, 24);

                    //config panel vill primario
                    P_vill.BackColor = Color.FromArgb(5, 12, 26);
                    P_vill.Height = 69;
                    P_vill.Dock = DockStyle.Top;

                    //configurações do desing
                    P_desing.BackColor = Color.Purple;
                    P_desing.Width = 18;
                    P_desing.Dock = DockStyle.Left;

                    P_separador.BackColor = Color.White;
                    P_separador.Height = 1;
                    P_separador.Dock = DockStyle.Top;

                    //add ao panel os controles
                    P_vill.Controls.Add(L_nome);
                    P_vill.Controls.Add(L_local);
                    P_vill.Controls.Add(L_tipo);
                    P_vill.Controls.Add(L_data);
                    P_vill.Controls.Add(P_desing);
                    //add o panel vill principal
                    panelVill.Controls.Add(P_separador);
                    panelVill.Controls.Add(P_vill);

                }
            }
            else
            {
                panelVill.Controls.Clear();

                Label info = new Label();
                info.Text = "Ainda não possui histórico";
                info.ForeColor = Color.White;
                info.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                info.Dock = DockStyle.Top;

                panelVill.Controls.Add(info);
            }

        }

        private const string PathFile = @"Modules/Historico.json";
        private List<HistoricoObj> Obj_historico = new List<HistoricoObj>();
    }
}
