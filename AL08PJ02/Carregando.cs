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
    public partial class Carregando : Form
    {
        public Carregando()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void carregarPerguntas(int id, string perg, string alt1, string alt2, string alt3, string alt4, int correto, double valor)
        {
            try
            {
                if (correto < 1 || correto > 4)
                    throw new FormatException();
                if (id < 1)
                    throw new FormatException();
            }
            catch (FormatException ex)
            {
                Form1 Form1 = new Form1();
                Form1.erroReport($"Erro na geração da questão. $ID=[{id}], $PERG=[{perg}], $CORRETO=[{correto}]", ex);
                return;
            }
            int x = id - 1;
            Saves.Questao[x].aquestao = perg;
            Saves.Questao[x].alt1 = alt1;
            Saves.Questao[x].alt2 = alt2;
            Saves.Questao[x].alt3 = alt3;
            Saves.Questao[x].alt4 = alt4;
            Saves.Questao[x].correto = correto;
            Saves.Questao[x].valor = valor;

            //MessageBox.Show($"id={id}, x={x}, perg={perg}, status={Saves.status}");
        }

        public void iniciarPergunta()
        {
            Pergunta Pergunta = new Pergunta();
            Pergunta.ShowDialog();
            this.Hide();
            this.Dispose();
            this.Close();
        }

        private async void Carregando_Load_1(object sender, EventArgs e)
        {
            carregarPerguntas(1, "Qual é a capital dos EUA?", "Nova Iorque", "Miami", "Washington", "Pindamonhagaba", 3, 1000);
            carregarPerguntas(2, "Qual o planeta mais quente do Sistema Solar?", "Vênus", "Mercúrio", "Terra", "Júpiter", 1, 10000);
            carregarPerguntas(3, "O que é a Via Láctea?", "Marca de Leite", "Civilização Antiga", "Marca de Carro", "Galáxia", 4, 20000);
            carregarPerguntas(4, "Qual dessas cidades já foi capital do Brasil?", "Rio Branco (AC)", "Salvador (BA)", "São Paulo (SP)", "Xique-Xique (BA)", 2, 30000);
            carregarPerguntas(5, "Qual a fórmula química da água?", "CO2", "H2O", "O2", "CH4", 2, 500000);
            carregarPerguntas(6, "Quem pintou a \"Mona Lisa\"?", "Romero Britto", "Vincent Van Gogh", "Leonardo da Vinci", "Leonardo DiCaprio", 3, 100000);
            carregarPerguntas(7, "Em qual ano o homem pisou na Lua pela primeira vez?", "1968", "1969", "1970", "1972", 2, 200000);
            carregarPerguntas(8, "Com qual desses países a França faz fronteira?", "Rússia", "Portugal", "Itália", "Grécia", 3, 300000);
            carregarPerguntas(9, "Após a Proclamação da República, qual foi o primeiro presidente do Brasil?", "Getúlio Vargas", "Deodoro da Fonseca", "Juscelino Kubitschek", "Nilo Peçanha", 2, 500000);
            carregarPerguntas(10, "O que foi o estopim da 1ª Guerra Mundial?", "Crise Econômica", "Assassinato", "Disputa territorial", "Criação do avião", 2, 1000000);
            carregarPerguntas(11, "Qual é o maior oceano do mundo?", "Atlântico", "Índico", "Pacífico", "Ártico", 3, 0);
            carregarPerguntas(12, "Quem criou a \"Turma da Mônica\"?", "Maurício de Souza", "Monteiro Lobato", "Ednaldo Pereira", "Marcelo de Nóbrega", 1, 0);
            carregarPerguntas(13, "Qual dessas pessoas participou da Reforma Protestante?", "Pôncio Pilatos", "Apóstolo Paulo", "Tomás de Aquino", "Martinho Lutero", 4, 0);

            /*
            Form1 Form1 = new Form1();
            Form1.walkman.Stop();
            switch (Saves.status)
            {
                case 0:
                    Form1.som("_1PERG1MIL");
                    break;
                case 1:
                    Form1.som("_2PERG10MIL");
                    break;
                case 2:
                    Form1.som("_3PERG20MIL");
                    break;
                case 3:
                    Form1.som("_4PERG30MIL");
                    break;
                case 4:
                    Form1.som("_5PERG50MIL");
                    break;
                case 5:
                    Form1.som("_6PERG100MIL");
                    break;
                case 6:
                    Form1.som("_7PERG200MIL");
                    break;
                case 7:
                    Form1.som("_8PERG300MIL");
                    break;
                case 8:
                    Form1.som("_9PERG500MIL");
                    break;
                case 9:
                    Form1.som("_10PERG1MILHAO");
                    break;
            }
            await Pare();
            */
            iniciarPergunta();
            this.Hide();
        }

        public async Task Pare()
        {
            await Task.Delay(5000);
        }
    }
}
