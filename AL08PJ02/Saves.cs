using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL08PJ02
{
    public class Saves
    {
        public struct savedata
        {
            public string jogador;
            public int acertos;
            public string datajogo;
        };

        public struct questoes
        {
            public string aquestao;
            public string alt1;
            public string alt2;
            public string alt3;
            public string alt4;
            public int correto;
            public double valor;
        };

        public static int MAXPERG = 10;
        public static int MAX = 255;

        public static savedata[] Savedata = new savedata[MAX];
        public static int savectn = 0;

        public static questoes[] Questao = new questoes[MAXPERG + 3];
        public static int status = 0;
    }
}
