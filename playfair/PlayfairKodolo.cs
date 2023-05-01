using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playfair
{
    internal class PlayfairKodolo
    {
        private char[,] matrix = new char[5,5];
        public PlayfairKodolo(string allomanynev)
        {
            using StreamReader sr = new(allomanynev);
            string szoveg = sr.ReadToEnd().Replace("\r\n", "");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = szoveg[i * 5 + j];
                }
            }

            //alternatív megoldás:
            /*
            int i = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                for (int j = 0; i < sor.Length; j++)
                {
                    matrix[i, j] = sor[j];
                }
                i++;
            } 
            */
        }

        public int SorIndex(char keresett)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keresett == matrix[i, j]) return i;
                }
            }
            return -1;
        }

        public int OszlopIndex(char keresett)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keresett == matrix[i, j]) return j;
                }
            }
            return -1;
        }

        public string KodolBetupar(string betupar)
        {
            //0: x1
            //1: y1
            //2: x2
            //3: y2
            int[] indexek = { SorIndex(betupar[0]), OszlopIndex(betupar[0]), SorIndex(betupar[1]), OszlopIndex(betupar[1]) };
            int[] behelyettesitendoIndexek = new int[4];

            //a
            if (indexek[0] == indexek[2])
            {
                behelyettesitendoIndexek[0] = indexek[0];
                behelyettesitendoIndexek[1] = indexek[1] < 4 ? indexek[1] + 1 : 0;
                behelyettesitendoIndexek[2] = indexek[2];
                behelyettesitendoIndexek[3] = indexek[3] < 4 ? indexek[3] + 1 : 0;
            }

            //b
            else if (indexek[1] == indexek[3])
            {
                behelyettesitendoIndexek[0] = indexek[0] < 4 ? indexek[0] + 1 : 0;
                behelyettesitendoIndexek[1] = indexek[1];
                behelyettesitendoIndexek[2] = indexek[2] < 4 ? indexek[2] + 1 : 0;
                behelyettesitendoIndexek[3] = indexek[3];
            }

            //c
            else
            {
                behelyettesitendoIndexek[0] = indexek[0];
                behelyettesitendoIndexek[1] = indexek[3];
                behelyettesitendoIndexek[2] = indexek[2];
                behelyettesitendoIndexek[3] = indexek[1];
            }

            return $"{matrix[behelyettesitendoIndexek[0], behelyettesitendoIndexek[1]]}{matrix[behelyettesitendoIndexek[2], behelyettesitendoIndexek[3]]}";
        }
    }
}
