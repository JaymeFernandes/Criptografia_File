using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Criptografia.Modules.Gerenciar_Arquivos;

namespace Criptografia.Pages.Histórico
{
    public partial class F_Histórico : Form
    {
        private const string PathFile = @"Modules/Historico.json";
        private List<CryptHistoryEntry> Obj_historico = new List<CryptHistoryEntry>();
        private const int BackgroundColorArgb = unchecked((int)0xFF050C1A); // ARGB: 5, 12, 26
        private const int DesignColorArgb = unchecked((int)0xFF800080); // ARGB: 128, 0, 128
        private const int SeparatorColorArgb = unchecked((int)0xFFFFFFFF); // ARGB: 255, 255, 255


        public F_Histórico()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        #region Carregamento das informações

        /// <summary>
        /// Carrega o histórico de criptografia do arquivo JSON e exibe as informações na interface do usuário.
        /// </summary>
        private void CarregarHistorico()
        {
            if (File.Exists(PathFile))
                Obj_historico = CarregarHistoricoDoJson();

            P_Vill.Controls.Clear();

            if (Obj_historico.Count > 0)
            {
                foreach (var obj in Obj_historico)
                    AdicionarControlesHistorico(obj);
            }
            else
            {
                ExibirMensagemSemHistorico();
            }
        }

        /// <summary>
        /// Carrega o histórico de criptografia do arquivo JSON e retorna a lista de objetos históricos.
        /// </summary>
        /// <returns>A lista de objetos históricos carregada do arquivo JSON.</returns>
        private List<CryptHistoryEntry> CarregarHistoricoDoJson()
        {
            string json = ArquivoHandler.LerArquivo(PathFile);
            return JSON.ConvertObject<CryptHistoryEntry>(json);
        }

        /// <summary>
        /// Adiciona controles ao painel P_Vill exibindo informações do histórico.
        /// </summary>
        /// <param name="obj">Objeto que representa o histórico a ser exibido.</param>
        private void AdicionarControlesHistorico(CryptHistoryEntry obj)
        {
            var P_vill = CriarPanel(Color.FromArgb(BackgroundColorArgb), 69, 0, DockStyle.Top);
            var P_desing = CriarPanel(Color.FromArgb(DesignColorArgb), 0, 18, DockStyle.Left);
            var P_separador = CriarPanel(Color.FromArgb(SeparatorColorArgb), 1, 0, DockStyle.Top);

            var L_nome = CriarLabel($"Nome: {obj.name}", new Size(300, 21), new Point(24, 0));
            var L_local = CriarLabel($"Local: {obj.pathFile}", new Size(600, 21), new Point(24, 45));
            var L_tipo = CriarLabel($"Tipo: {obj.TypeCript}", new Size(300, 21), new Point(375, 0));
            var L_data = CriarLabel($"Data: {obj.date.ToString()}", new Size(300, 21), new Point(24, 24));

            P_vill.Controls.AddRange(new Control[] { P_desing, L_nome, L_local, L_tipo, L_data });
            P_Vill.Controls.AddRange(new Control[] { P_vill, P_separador });
        }

        /// <summary>
        /// Exibe uma mensagem informando que não há histórico disponível.
        /// </summary>
        private void ExibirMensagemSemHistorico()
        {
            P_Vill.Controls.Clear();

            var info = CriarLabel("Ainda não possui histórico", new Size(0, 0), new Point(0, 0));
            info.ForeColor = Color.White;
            info.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            P_Vill.Controls.Add(info);
        }

        #endregion

        #region Criação dos componentes

        /// <summary>
        /// Cria e retorna um novo painel com as propriedades especificadas.
        /// </summary>
        /// <param name="corDeFundo">A cor de fundo do painel.</param>
        /// <param name="altura">A altura do painel.</param>
        /// <param name="largura">A largura do painel.</param>
        /// <param name="dockStyle">O estilo de ancoragem do painel.</param>
        /// <returns>O painel criado.</returns>
        private Panel CriarPanel(Color corDeFundo, int altura, int largura, DockStyle dockStyle)
        {
            return new Panel
            {
                BackColor = corDeFundo,
                Width = largura,
                Height = altura,
                Dock = dockStyle
            };
        }

        /// <summary>
        /// Cria e retorna uma nova etiqueta com as propriedades especificadas.
        /// </summary>
        /// <param name="texto">O texto da etiqueta.</param>
        /// <param name="tamanho">O tamanho da etiqueta.</param>
        /// <param name="localizacao">A localização da etiqueta.</param>
        /// <returns>A etiqueta criada.</returns>
        private Label CriarLabel(string texto, Size tamanho, Point localizacao)
        {
            return new Label
            {
                Text = texto,
                Size = tamanho,
                Location = localizacao,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(BackgroundColorArgb)
            };
        }

        #endregion

    }
}
