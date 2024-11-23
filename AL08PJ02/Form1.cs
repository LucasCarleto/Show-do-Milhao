using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace AL08PJ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int MAX = Saves.MAX;
        public static string database = "SAVES.DB";
        public static string log = "LOG.SDB";
        public static string dataReg = System.DateTime.Now.ToString();

        public void salvar(string jogador, int acertos)
        {
            try
            {
                if (acertos > Saves.MAXPERG || acertos < 0)
                    throw new FormatException();
                dataReg = System.DateTime.Now.ToString();
                int i = Saves.savectn;

                string dinheiro;

                if (acertos == 1)
                    dinheiro = "1";
                else if (acertos == 2)
                    dinheiro = "10";
                else if (acertos == 3)
                    dinheiro = "20";
                else if (acertos == 4)
                    dinheiro = "30";
                else if (acertos == 5)
                    dinheiro = "50";
                else if (acertos == 6)
                    dinheiro = "100";
                else if (acertos == 7)
                    dinheiro = "200";
                else if (acertos == 8)
                    dinheiro = "300";
                else if (acertos == 9)
                    dinheiro = "500";
                else if (acertos == 10)
                    dinheiro = "M";
                else
                    dinheiro = "N";

                Saves.Savedata[i].jogador = jogador;
                Saves.Savedata[i].acertos = acertos;
                Saves.Savedata[i].datajogo = dinheiro;
                var item = new ListViewItem(new[] { jogador, acertos.ToString(), (Saves.MAXPERG - acertos).ToString(), dinheiro });
                lstPlacar.Items.Add(item);
                File.AppendAllText(database, $"@\n1#{jogador}\n2#{acertos.ToString()}\n3#{dinheiro}\n");
                Saves.savectn++;
            }
            catch (IndexOutOfRangeException ex)
            {
                erroReport($"O placar está lotado! [Reportado ao usuário]", ex);
                MessageBox.Show("ERRO: O placar está lotado!");
            }
            catch (FormatException ex)
            {
                erroReport($"Dados de save inválidos! Ignorando registro de save...", ex);
                return;
            }
        }

        public void botaoEstado(Button botao, int estado)
        {
            if (estado == 0)
                botao.ForeColor = Color.Black;
            else if (estado == 1)
                botao.ForeColor = Color.White;
        }

        public void saveLoad(string jogador, int acertos, string dataReg)
        {
            var item = new ListViewItem(new[] { jogador, acertos.ToString(), (Saves.MAXPERG - acertos).ToString(), dataReg });
            lstPlacar.Items.Add(item);
        }

        public static int carregaAux = 0;
        public static int play = 0;
        public void carregaSaves()
        {
            play = 0;
            carregaAux = 0;
            lstPlacar.Items.Clear();
            try
            {
                string[] savesReg = File.ReadAllLines(database);
                string[] jogador = new string[MAX];
                string[] acertosAUX = new string[MAX];
                string[] data = new string[MAX];

                try
                {
                    foreach (string line in savesReg)
                    {
                        //MessageBox.Show($"jogador[{play}] = savesReg[{carregaAux}]; MAX={MAX}; jogador={jogador.Length}, savesReg={savesReg.Length}\n\nsavesReg:\n{File.ReadAllText(database)}");
                        if (line.StartsWith("1#"))
                            jogador[play] = savesReg[carregaAux];
                        else if (line.StartsWith("2#"))
                            acertosAUX[play] = savesReg[carregaAux];
                        else if (line.StartsWith("3#"))
                        {
                            data[play] = savesReg[carregaAux];
                            play++;
                        }
                        carregaAux++;
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show($"ERRO: jogador[{play}] = savesReg[{carregaAux}]; MAX={MAX}; jogador={jogador.Length}, savesReg={savesReg.Length}\n\nsavesReg:\n{File.ReadAllText(database)}");
                }

                int[] acertos = new int[255];

                for (int i = 0; i < play; i++)
                {
                    jogador[i] = jogador[i].Substring(2);
                    jogador[i] = jogador[i].Trim('\n');

                    acertosAUX[i] = acertosAUX[i].Substring(2);
                    acertosAUX[i] = acertosAUX[i].Trim('\n');
                    acertos[i] = int.Parse(acertosAUX[i]);

                    data[i] = data[i].Substring(2);
                    data[i] = data[i].Trim('\n');

                    string aux = "";
                    if (data[i] == "N")
                        data[i] = "Nada";
                    else
                    {
                        aux = "R$ ";
                        if (data[i] == "M")
                            data[i] = "1 milhão";
                        else
                            data[i] += " mil";
                    }

                    saveLoad(jogador[i], acertos[i], $"{aux}{data[i]}");
                }

                /*
                carregaAux++;
                string jogador = savesReg[carregaAux];
                carregaAux++;
                int acertos = int.Parse(savesReg[carregaAux]);
                carregaAux++;
                string data = savesReg[carregaAux];
                carregaAux++;*/
            }
            catch (FileNotFoundException ex)
            {
                erroReport($"Arquivo {database} não encontrado. Criando um novo...", ex);
                File.AppendAllText(database, "");
                carregaSaves();
            }
        }

        public SoundPlayer walkman = new SoundPlayer();

        public void som(string arq)
        {
            try
            {
                var stream = Properties.Resources.ResourceManager.GetStream(arq);
                walkman = new SoundPlayer(stream);
                walkman.Play();
            }
            catch (FileNotFoundException ex)
            {
                erroReport($"Arquivo de áudio {arq} não encontrado!", ex);
                return;
            }
        }

        public void erroReport(string txt, Exception ex)
        {
            File.AppendAllText(log, $"# RELATÓRIO {DateTime.Now} #:\n\n  ERRO: {txt}\n  {ex.GetType().Name}, 0x{ex.GetHashCode().ToString("X")}\n================================================================\n");
        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Carregando Carregando = new Carregando();
            Carregando.ShowDialog();
            carregaSaves();
            this.Show();
            som("SHOWDOMILHAO");
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Tem certeza de que deseja limpar o placar? Essa ação é irreversível!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (a == DialogResult.Yes)
            {
                lstPlacar.Items.Clear();
                File.Delete(database);
            }
            else
                return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            som("SHOWDOMILHAO");
            carregaSaves();

            lstPlacar.OwnerDraw = true;
            lstPlacar.DrawColumnHeader += ListView_DrawColumnHeader;
            lstPlacar.DrawItem += ListView_DrawItem;
            lstPlacar.DrawSubItem += ListView_DrawSubItem;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            botaoEstado(btnStart, 0);
            btnStart.BackgroundImage = Properties.Resources.BT1H;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            botaoEstado(btnStart, 1);
            btnStart.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            botaoEstado(btnStart, 1);
            btnStart.BackgroundImage = Properties.Resources.BT1C;
        }

        private void btnStart_MouseUp(object sender, MouseEventArgs e)
        {
            botaoEstado(btnStart, 1);
            btnStart.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            botaoEstado(btnLimpar, 0);
            btnLimpar.BackgroundImage = Properties.Resources.BT1H;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            botaoEstado(btnLimpar, 1);
            btnLimpar.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnLimpar_MouseDown(object sender, MouseEventArgs e)
        {
            botaoEstado(btnLimpar, 1);
            btnLimpar.BackgroundImage = Properties.Resources.BT1C;
        }

        private void btnLimpar_MouseUp(object sender, MouseEventArgs e)
        {
            botaoEstado(btnLimpar, 1);
            btnLimpar.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            botaoEstado(btnSair, 0);
            btnSair.BackgroundImage = Properties.Resources.BT2H;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            botaoEstado(btnSair, 1);
            btnSair.BackgroundImage = Properties.Resources.BT2;
        }

        private void btnSair_MouseDown(object sender, MouseEventArgs e)
        {
            botaoEstado(btnSair, 1);
            btnSair.BackgroundImage = Properties.Resources.BT1C;
        }

        private void btnSair_MouseUp(object sender, MouseEventArgs e)
        {
            botaoEstado(btnSair, 1);
            btnSair.BackgroundImage = Properties.Resources.BT2;
        }

        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Alterar a cor de fundo do cabeçalho da coluna
            e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);

            // Alterar a cor do texto no cabeçalho da coluna
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.DarkBlue, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Desenhar os itens (não alteramos as cores aqui)
            e.DrawDefault = true;
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Desenhar os subitens (não alteramos as cores aqui)
            e.DrawDefault = true;
        }
    }
}
