using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AL08PJ02
{
    public partial class Pergunta : Form
    {
        public Pergunta()
        {
            InitializeComponent();
        }

        Form1 Form1 = new Form1();
        Random random = new Random();

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                this.Close();
        }

        public Color altDef = Color.FromArgb(64, 128, 255);
        public Color altSel = Color.FromArgb(255, 170, 32);
        public Color altErr = Color.FromArgb(170, 32, 32);
        public Color altCrt = Color.FromArgb(32, 170, 32);
        public Color indisp = Color.FromArgb(100, 115, 145);
        public Color cartab = Color.FromArgb(0, 170, 0);

        public bool jogou = false;
        public int acertos = 0;
        public string jogador = "DESCONHECIDO";
        public bool emPerg = true;
        public bool desistiu = true;

        public async void carregandoPergunta()
        {
            carregar.Visible = true;
            Form1 Form1 = new Form1();
            Form1.walkman.Stop();
            string a = "Carregando pergunta...\nValendo R$ ";
            switch (Saves.status)
            {
                case 0:
                    carregar.Text = $"{a}1 mil";
                    Form1.som("_1PERG1MIL");
                    break;
                case 1:
                    carregar.Text = $"{a}10 mil";
                    Form1.som("_2PERG10MIL");
                    break;
                case 2:
                    carregar.Text = $"{a}20 mil";
                    Form1.som("_3PERG20MIL");
                    break;
                case 3:
                    carregar.Text = $"{a}30 mil";
                    Form1.som("_4PERG30MIL");
                    break;
                case 4:
                    carregar.Text = $"{a}50 mil";
                    Form1.som("_5PERG50MIL");
                    break;
                case 5:
                    carregar.Text = $"{a}100 mil";
                    Form1.som("_6PERG100MIL");
                    break;
                case 6:
                    carregar.Text = $"{a}200 mil";
                    Form1.som("_7PERG200MIL");
                    break;
                case 7:
                    carregar.Text = $"{a}300 mil";
                    Form1.som("_8PERG300MIL");
                    break;
                case 8:
                    carregar.Text = $"{a}500 mil";
                    Form1.som("_9PERG500MIL");
                    break;
                case 9:
                    carregar.Text = $"{a}1 milhão";
                    Form1.som("_10PERG1MILHAO");
                    break;
            }
            await Pare(7000);
            carregar.Visible = false;
        }

        public void recarregar()
        {
            if (pulos < 3)
            {
                btnPula.BackColor = altDef;
                btnPula.Visible = true;
            }
            else
            {
                btnPula.BackColor = indisp;
                btnPula.Visible = false;
            }

            if (universitario == false)
            {
                btnUniversitario.BackColor = indisp;
                btnUniversitario.Visible = false;
            }
            else
            {
                btnUniversitario.BackColor = altDef;
                btnUniversitario.Visible = true;
            }

            if (cartas == false)
            {
                btnCartas.BackColor = indisp;
                btnCartas.Visible = false;
            }
            else
            {
                btnCartas.BackColor = altDef;
                btnCartas.Visible = true;
            }

            if (placas == false)
            {
                btnPlacas.BackColor = indisp;
                btnPlacas.Visible = false;
            }
            else
            {
                btnPlacas.BackColor = altDef;
                btnPlacas.Visible = true;
            }

            lblAltA.BackColor = altDef;
            lblAltB.BackColor = altDef;
            lblAltC.BackColor = altDef;
            lblAltD.BackColor = altDef;
            lblCerto.Text = "";

            panel1.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();

            panelSombra.Visible = false;

            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            car1.Enabled = true;
            car2.Enabled = true;
            car3.Enabled = true;
            car4.Enabled = true;

            lblAltA.Enabled = true;
            lblAltA.Visible = true;
            lblAltA.BackColor = altDef;

            lblAltB.Enabled = true;
            lblAltB.Visible = true;
            lblAltB.BackColor = altDef;

            lblAltC.Enabled = true;
            lblAltC.Visible = true;
            lblAltC.BackColor = altDef;

            lblAltD.Enabled = true;
            lblAltD.Visible = true;
            lblAltD.BackColor = altDef;

            car1.Image = Properties.Resources.CARB;
            car2.Image = Properties.Resources.CARB;
            car3.Image = Properties.Resources.CARB;
            car4.Image = Properties.Resources.CARB;
            label9.Text = "SELECIONE UMA DAS CARTAS";

            label6.Text = "QUE PENA, VOCÊ ERROU!";
            btnErrou.BackColor = Color.FromArgb(170, 32, 32);

            emPerg = true;
        }

        public void iniciaTudo()
        {
            recarregar();
            burro = 0;
            btnPula.Text = $"Pular ({3 - pulos})";
            carregar.Location = new Point(0, 0);
            carregar.Size = new Size(this.Width, this.Height);
            int i = Saves.status;
            string valor = "";
            if (Saves.Questao[i].valor < 1000000)
                valor = $"{Saves.Questao[i].valor / 1000} mil";
            else
                valor = "1 milhão";
            lblPergunta.Text = $"Pergunta {Saves.status + 1} (R$ {valor}). {Saves.Questao[i].aquestao}";
            lblAltA.Text = $"      {Saves.Questao[i].alt1}";
            lblAltB.Text = $"      {Saves.Questao[i].alt2}";
            lblAltC.Text = $"      {Saves.Questao[i].alt3}";
            lblAltD.Text = $"      {Saves.Questao[i].alt4}";
        }

        private void Pergunta_Load_1(object sender, EventArgs e)
        {
            carregandoPergunta();
            iniciaTudo();
        }

        public int burro = 0;

        public void cheque(Label label)
        {
            burro++;
            label.BackColor = altSel;
            lblCerto.Text = "Está certo disso? (Duplo-Clique se sim)";

            if (lblAltA != label)
                lblAltA.BackColor = altDef;
            if (lblAltB != label)
                lblAltB.BackColor = altDef;
            if (lblAltC != label)
                lblAltC.BackColor = altDef;
            if (lblAltD != label)
                lblAltD.BackColor = altDef;

            Form1.walkman.Stop();
            if (burro > 4)
            {
                Form1.som("SELECTMUITO");
                burro = 0;
            }
            else if (random.Next(1, 4) == 2)
                Form1.som("SELECT2");
            else if (random.Next(1, 4) == 3)
                Form1.som("SELECT3");
            else
                Form1.som("SELECT1");
        }

        public async void confirma(Label label, int selecao)
        {
            Form1.walkman.Stop();
            Form1.som("CONFIRMOU");
            await Pare(2000);
            jogou = true;
            if (selecao == Saves.Questao[Saves.status].correto)
            { 
                acertos++;
                label.BackColor = altCrt;
                lblCerto.Text = "";
                Form1.walkman.Stop();
                if (Saves.status < Saves.MAXPERG - 1)
                {
                    Form1.som("ACERTOU");
                    label5.Text = "CERTA RESPOSTA!";
                    panel1.Enabled = true;
                    panel1.Visible = true;
                    panelSombra.Visible = true;
                    emPerg = false;
                }
                else
                {
                    btnErrou.BackColor = Color.FromArgb(32, 170, 32);
                    Form1.som("GANHOU");
                    label6.Text = "GANHOU R$ 1 MILHÃO!";
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    panelSombra.Visible = true;
                    emPerg = false;
                }
            }
            else
            {
                btnErrou.BackColor = Color.FromArgb(170, 32, 32);
                Label tmp;
                switch (Saves.Questao[Saves.status].correto)
                {
                    case 1:
                        tmp = lblAltA;
                        break;
                    case 2:
                        tmp = lblAltB;
                        break;
                    case 3:
                        tmp = lblAltC;
                        break;
                    case 4:
                        tmp = lblAltD;
                        break;
                    default:
                        tmp = lblAltA;
                        break;
                }
                for (int i = 0; i < 4; i++)
                {
                    tmp.BackColor = altDef;
                    await Pare(250);
                    tmp.BackColor = altCrt;
                    await Pare(250);
                }

                label.BackColor = altErr;
                lblCerto.Text = "";
                Form1.walkman.Stop();
                Form1.som("ERROU");
                panel2.Enabled = true;
                panel2.Visible = true;
                panelSombra.Visible = true;
                emPerg = false;
            }
        }

        private void lblAltA_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                cheque(lblAltA);
        }

        private void lblAltB_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                cheque(lblAltB);
        }

        private void lblAltC_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                cheque(lblAltC);
        }

        private void lblAltD_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                cheque(lblAltD);
        }

        private void altCirculo(Label label, string text, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Cores
            Color circleColor = ColorTranslator.FromHtml("#c00000");
            Color textColor = ColorTranslator.FromHtml("#fafbfc");

            // Dimensões do círculo
            int diameter = 64; // Diâmetro do círculo
            int x = 16; // Posição X do círculo
            int y = (label.Height - diameter) / 2; // Centralizado verticalmente

            // Desenha o círculo
            using (Brush brush = new SolidBrush(circleColor))
            {
                g.FillEllipse(brush, x, y, diameter, diameter);
            }

            // Desenha a letra no centro do círculo
            using (Brush textBrush = new SolidBrush(textColor))
            {
                Font font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
                SizeF textSize = g.MeasureString(text, font);
                g.DrawString(text, font, textBrush, x + ((diameter - textSize.Width) / 2)+ 1, y + ((diameter - textSize.Height) / 2) + 2);
            }
        }

        private void lblAltA_Paint_1(object sender, PaintEventArgs e)
        {
            altCirculo(lblAltA, "A", e);
        }

        private void lblAltB_Paint(object sender, PaintEventArgs e)
        {
            altCirculo(lblAltB, "B", e);
        }

        private void lblAltC_Paint(object sender, PaintEventArgs e)
        {
            altCirculo(lblAltC, "C", e);
        }

        private void lblAltD_Paint(object sender, PaintEventArgs e)
        {
            altCirculo(lblAltD, "D", e);
        }

        private void lblAltA_DoubleClick(object sender, EventArgs e)
        {
            if (emPerg == true)
                confirma(lblAltA, 1);
        }

        private void lblAltB_DoubleClick(object sender, EventArgs e)
        {
            if (emPerg == true)
                confirma(lblAltB, 2);
        }

        private void lblAltC_DoubleClick(object sender, EventArgs e)
        {
            if (emPerg == true)
                confirma(lblAltC, 3);
        }

        private void lblAltD_DoubleClick(object sender, EventArgs e)
        {
            if (emPerg == true)
                confirma(lblAltD, 4);
        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            Saves.status++;
            carregandoPergunta();
            iniciaTudo();
        }

        public async Task Pare(int tempo)
        {
            await Task.Delay(tempo);
        }

        public bool respondido = false;

        private void btnErrou_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                var a = MessageBox.Show("Digite seu nome antes de sair.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a == DialogResult.OK)
                {
                    textBox1.Focus();
                    return;
                }
                else
                {
                    respondido = true;
                    this.Close();
                }
            }
            else
            {
                jogador = textBox1.Text;
                respondido = true;
                this.Close();
            }
        }

        private void Pergunta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (desistiu == true)
            {
                Form1.som("PARAR");
                if (jogou == true)
                {
                    emPerg = false;
                    if (respondido == false)
                    {
                        e.Cancel = true;
                        panel2.Enabled = true;
                        panel2.Visible = true; 
                        panelSombra.Visible = true;
                        label6.Text = "VOCÊ DESISTIU DO JOGO";
                        return;
                    }
                    else
                    {
                        Saves.status = 0;
                        pulos = 0;
                        Form1 Form1 = new Form1();
                        Form1.salvar(jogador, acertos);
                        jogou = false;
                        respondido = false;
                        universitario = true;
                        cartas = true;
                        placas = true;
                    }
                }
            }
        }

        public int pulos = 0;
        public bool universitario = true;
        public bool cartas = true;
        public bool placas = true;

        private void btnPula_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                if (pulos < 3)
                {
                    Carregando carregando = new Carregando();
                    int a = pulos;
                    carregando.carregarPerguntas(Saves.status + 1, Saves.Questao[a + 10].aquestao, Saves.Questao[a + 10].alt1, Saves.Questao[a + 10].alt2, Saves.Questao[a + 10].alt3, Saves.Questao[a + 10].alt4, Saves.Questao[a + 10].correto, Saves.Questao[Saves.status].valor);
                    pulos++;

                    carregandoPergunta();
                    iniciaTudo();
                }
        }

        private async void btnUniversitario_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                if (universitario == true)
                {
                    universitario = false;
                    btnUniversitario.BackColor = indisp;
                    btnUniversitario.Visible = false;

                    voto1.Visible = false;
                    voto2.Visible = false;
                    voto3.Visible = false;
                    voto4.Visible = false;

                    car1.Visible = false;
                    car2.Visible = false;
                    car3.Visible = false;
                    car4.Visible = false;

                    char a = (char)(Saves.Questao[Saves.status].correto + 64);
                    label9.Text = $"Resposta: {a}";
                    panel3.BackColor = cartab;
                    label9.BackColor = cartab;
                    panel3.Enabled = true;
                    panel3.Visible = true;
                    panelSombra.Visible = true;
                    emPerg = false;

                    await Pare(4000);
                    btnUniversitario.BackColor = indisp;
                    btnUniversitario.Visible = false;
                    panel3.Enabled = false;
                    panel3.Visible = false;
                    panelSombra.Visible = false;
                    emPerg = true;
                }
        }

        private void btnCartas_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                if (cartas == true)
                {
                    Form1.som("CARTA1");
                    car1.Visible = true;
                    car1.Enabled = true;

                    car2.Visible = true;
                    car2.Enabled = true;

                    car3.Visible = true;
                    car3.Enabled = true;

                    car4.Visible = true;
                    car4.Enabled = true;

                    voto1.Visible = false;
                    voto1.Enabled = true;

                    voto2.Visible = false;
                    voto2.Enabled = true;
                    
                    voto3.Visible = false;
                    voto3.Enabled = true;
                    
                    voto4.Visible = false;
                    voto4.Enabled = true;

                    car1.Image = Properties.Resources.CARB;
                    car2.Image = Properties.Resources.CARB;
                    car3.Image = Properties.Resources.CARB;
                    car4.Image = Properties.Resources.CARB;

                    label9.Text = "SELECIONE UMA DAS CARTAS";
                    cartas = false;
                    panel3.BackColor = cartab;
                    label9.BackColor = cartab;
                    panel3.Enabled = true;
                    panel3.Visible = true;
                    panelSombra.Visible = true;
                    emPerg = false;
                }

        }

        private async void btnPlacas_Click(object sender, EventArgs e)
        {
            if (emPerg == true)
                if (placas == true)
                {
                    int a = random.Next(1, 2);
                    if (a == 1)
                        Form1.som("PLACA1");
                    else
                        Form1.som("PLACA2");

                    label9.Text = "Placas";

                    car1.Visible = true;
                    car1.Enabled = false;

                    car2.Visible = true;
                    car2.Enabled = false;

                    car3.Visible = true;
                    car3.Enabled = false;

                    car4.Visible = true;
                    car4.Enabled = false;


                    voto1.Visible = true;
                    voto2.Visible = true;
                    voto3.Visible = true;
                    voto4.Visible = true;

                    car1.Image = Properties.Resources.PLAC;
                    car2.Image = Properties.Resources.PLAC;
                    car3.Image = Properties.Resources.PLAC;
                    car4.Image = Properties.Resources.PLAC;

                    voto1.Text = "";
                    voto2.Text = "";
                    voto3.Text = "";
                    voto4.Text = "";

                    placas = false;
                    panel3.BackColor = cartab;
                    label9.BackColor = cartab;
                    panel3.Enabled = true;
                    panel3.Visible = true;
                    panelSombra.Visible = true;
                    emPerg = false;

                    await Pare(3000);

                    for (int i = 0; i < 4; i++)
                    {
                        int aux = random.Next(1, 4);
                        char voto;

                        if (aux == 1)
                            voto = 'A';
                        else if (aux == 2)
                            voto = 'B';
                        else if (aux == 3)
                            voto = 'C';
                        else
                            voto = 'D';

                        if (i == 0)
                            voto1.Text = voto.ToString();
                        else if (i == 1)
                            voto2.Text = voto.ToString();
                        else if (i == 2)
                            voto3.Text = voto.ToString();
                        else
                            voto4.Text = voto.ToString();
                    }

                    await Pare(3000);
                    btnPlacas.BackColor = indisp;
                    btnPlacas.Visible = false;
                    panel3.Enabled = false;
                    panel3.Visible = false;
                    panelSombra.Visible = false;
                    emPerg = true;
                }
        }

        public int SelCarta(PictureBox car)
        {
            car1.Enabled = false;
            car2.Enabled = false;
            car3.Enabled = false;
            car4.Enabled = false;
            int aux = random.Next(0, 3);
            if (aux == 0)
                car.Image = Properties.Resources.CAR0;
            else if (aux == 1)
                car.Image = Properties.Resources.CAR1;
            else if (aux == 2)
                car.Image = Properties.Resources.CAR2;
            else if (aux == 3)
                car.Image = Properties.Resources.CAR3;
            return aux;
        }

        public async void procCartas(int a)
        {
            if (a != 0 && a < 3)
            {
                int aux2 = Saves.Questao[Saves.status].correto;
                int aux = aux2;

                for (int i = 0; i < a; i++)
                {
                    int block = 0;
                    int block2 = 0;
                    int block3 = 0;
                    if (lblAltA.Enabled == false && block == 0)
                        block = 1;
                    else if (lblAltB.Enabled == false && block == 0)
                        block = 2;
                    else if (lblAltC.Enabled == false && block == 0)
                        block = 3;
                    else if (lblAltD.Enabled == false && block == 0)
                        block = 4;
                    else
                    {
                        if (lblAltA.Enabled == false && block2 == 0)
                            block2 = 1;
                        else if (lblAltB.Enabled == false && block2 == 0)
                            block2 = 2;
                        else if (lblAltC.Enabled == false && block2 == 0)
                            block2 = 3;
                        else if (lblAltD.Enabled == false && block2 == 0)
                            block2 = 4;
                        else
                        {
                            if (lblAltA.Enabled == false)
                                block3 = 1;
                            else if (lblAltB.Enabled == false)
                                block3 = 2;
                            else if (lblAltC.Enabled == false)
                                block3 = 3;
                            else if (lblAltD.Enabled == false)
                                block3 = 4;
                        }
                    }
                    while (aux == aux2 || aux == block || aux == block2)
                    {
                        aux = random.Next(1, 4);
                    }

                    if (aux == 1)
                    {
                        lblAltA.Enabled = false;
                        lblAltA.Visible = false;
                        lblAltA.BackColor = indisp;
                    }
                    if (aux == 2)
                    {
                        lblAltB.Enabled = false;
                        lblAltB.Visible = false;
                        lblAltB.BackColor = indisp;
                    }
                    if (aux == 3)
                    {
                        lblAltC.Enabled = false;
                        lblAltC.Visible = false;
                        lblAltC.BackColor = indisp;
                    }
                    if (aux == 4)
                    {
                        lblAltD.Enabled = false;
                        lblAltD.Visible = false;
                        lblAltD.BackColor = indisp;
                    }
                }
            }
            else if (a == 3)
            {
                int aux = Saves.Questao[Saves.status].correto;
                for (int i = 0; i < 4; i++)
                {
                    if (i+1 != aux)
                    {
                        if (i+1 == 1)
                        {
                            lblAltA.Enabled = false;
                            lblAltA.Visible = false;
                            lblAltA.BackColor = indisp;
                        }
                        else if (i+1 == 2)
                        {
                            lblAltB.Enabled = false;
                            lblAltB.Visible = false;
                            lblAltB.BackColor = indisp;
                        }
                        else if (i+1 == 3)
                        {
                            lblAltC.Enabled = false; 
                            lblAltC.Visible = false;
                            lblAltC.BackColor = indisp;
                        }
                        else if (i+1 == 4)
                        {
                            lblAltD.Enabled = false;
                            lblAltD.Visible = false;
                            lblAltD.BackColor = indisp;
                        }
                    }
                }
            }
            await Pare(2000);
            btnCartas.BackColor = indisp;
            btnCartas.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;
            panelSombra.Visible = false;
            emPerg = true;
        }

        private async void car1_Click(object sender, EventArgs e)
        {
            int a = SelCarta(car1);
            procCartas(a);
        }

        private void car2_Click(object sender, EventArgs e)
        {
            int a = SelCarta(car2);
            procCartas(a);
        }

        private void car3_Click(object sender, EventArgs e)
        {
            int a = SelCarta(car3);
            procCartas(a);
        }

        private void car4_Click(object sender, EventArgs e)
        {
            int a = SelCarta(car4);
            procCartas(a);
        }

        public void botaoEstado(Button botao, int estado)
        {
            if (estado == 0)
                botao.ForeColor = Color.Black;
            else if (estado == 1)
                botao.ForeColor = Color.White;
        }

        private void btnContinua_MouseEnter(object sender, EventArgs e)
        {
            botaoEstado(btnContinua, 0);
            btnContinua.BackgroundImage = Properties.Resources.BT1H;
        }

        private void btnContinua_MouseLeave(object sender, EventArgs e)
        {
            botaoEstado(btnContinua, 1);
            btnContinua.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnContinua_MouseDown(object sender, MouseEventArgs e)
        {
            botaoEstado(btnContinua, 1);
            btnContinua.BackgroundImage = Properties.Resources.BT1C;
        }

        private void btnContinua_MouseUp(object sender, MouseEventArgs e)
        {
            botaoEstado(btnContinua, 1);
            btnContinua.BackgroundImage = Properties.Resources.BT1;
        }

        private void btnErrou_MouseEnter(object sender, EventArgs e)
        {
            botaoEstado(btnErrou, 0);
            btnErrou.BackgroundImage = Properties.Resources.BT2H;
        }

        private void btnErrou_MouseLeave(object sender, EventArgs e)
        {
            botaoEstado(btnErrou, 1);
            btnErrou.BackgroundImage = Properties.Resources.BT2;
        }

        private void btnErrou_MouseDown(object sender, MouseEventArgs e)
        {
            botaoEstado(btnErrou, 1);
            btnErrou.BackgroundImage = Properties.Resources.BT1C;
        }

        private void btnErrou_MouseUp(object sender, MouseEventArgs e)
        {
            botaoEstado(btnErrou, 1);
            btnErrou.BackgroundImage = Properties.Resources.BT2;
        }

        public string textBox1tmp = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16)
                textBox1tmp = textBox1.Text;
            else
                textBox1.Text = textBox1tmp;
        }

        private void voltar_MouseEnter(object sender, EventArgs e)
        {
            voltar.Image = Properties.Resources.SETAAH;
        }

        private void voltar_MouseLeave(object sender, EventArgs e)
        {
            voltar.Image = Properties.Resources.SETAAC;
        }

        private void voltar_MouseDown(object sender, MouseEventArgs e)
        {
            voltar.Image = Properties.Resources.SETAAC;
        }

        private void voltar_MouseUp(object sender, MouseEventArgs e)
        {
            voltar.Image = Properties.Resources.SETAAC;
        }
    }
}
