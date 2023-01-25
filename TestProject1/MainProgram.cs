using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogo
{
    public class Main
    {
        private int limit;        // верхняя граница диапазона просеивания
        private int arrlength;     // размер массива
        private bool[] Prim;     // массив результатов просеивания

        public string Sundarammmm(int _limit)
        {
            limit = _limit;
            if (limit == 0)
            {
                return null;
            }
            if (limit % 2 == 0) limit -= 1;
            arrlength = limit + 1;
            Prim = new bool[arrlength];
            Sieve();
            string[] chisla = new string[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                chisla[i] = NextPrime(Prim, i);
            }
            string itog = perevodVstrocky(chisla);
            return itog;
        }

        public string NextPrime(bool[] Prim, int count)
        {
            if (Prim[count] == false)
                return Convert.ToString(2 * count + 3);
            return null;
        }

        public void Sieve()
        {
            int imax = ((int)Math.Sqrt(limit) - 1) / 2;
            for (int i = 1; i <= imax; i++)
            {
                int jmax = (arrlength - i) / (2 * i + 1);
                for (int j = i; j <= jmax; j++)
                {
                    Prim[2 * i * j + i + j - 1] = true;
                }
            }
        }

        public string perevodVstrocky(string[] chisla)
        {
            string[] mass = chisla;
            string stroka = null;
            for (int i = 0; i < mass.Length; i++)
            {
                stroka = stroka + " " + mass[i];
            }
            return stroka;
        }

        public int N { get; set; }

        public int Init(int n)
        {

            if ((n > 0) && (n <= 50))
            {
                N = n;
            }
            else
            {
                N = 0;
            }
            return N;
        }
        public string ToStr(List<int> numbers)
        {
            if (numbers == null)
            {
                return null;
            }
            string numbersStroke = "";

            foreach (int num in numbers)
            {
                numbersStroke += $"{num}; ";
            }
            return numbersStroke;

        }
    }
}
