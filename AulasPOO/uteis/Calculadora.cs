using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AulasPOO.uteis
{
    public class Calculadora
    {
        public int Soma(int num1, int num2) 
        {
            return num1 + num2; 
        }
        public static int Multiplica(int num1, int num2) 
        {
            return num1 * num2;
        }
        public static int Fatorial(int num1)
        {
            if (num1 == 1)
            {
                return 1;
            }
            else
                return num1 * Fatorial(num1 - 1);
        }

        public static float IMC(float peso, float altura)
        {
            return  peso / (altura * altura);
        }
        public static void Sorteador(List<string> lista, List<string> listaNova)
        {
            if (lista != null)
            {
                var rand = new Random();
                var nextRandString = rand.Next(0, lista.Count);
                var randString = lista[nextRandString];
                listaNova.Add(randString);
                lista.Remove(randString);
            }
        }

    }
}