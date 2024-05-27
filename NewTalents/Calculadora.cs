using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int v1, int v2)
        {
            int res = v1 + v2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int Subtrair(int v1, int v2)
        {
            int res = v1 - v2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int Multiplicar(int v1, int v2)
        {
            int res = v1 * v2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int Dividir(int v1, int v2)
        {
            int res = v1 / v2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }

    }
}
