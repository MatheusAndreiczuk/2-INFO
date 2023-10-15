using System;

namespace PositMedia
{
    public class Program
    {
        public static int positivos = 0;
        public static float media, soma = 0;
        public static float[] valores = new float[6];
        static void Main(string[] args)
        {
            Recebe();
            Positivos();
            CalcMedia();
            Mostra();
        }

        public static void Recebe()
        {
            for (int i = 0; i < 6; i++)
            {
               valores[i] = float.Parse(Console.ReadLine());
            }
        }

        public static void Positivos()
        {
            for (int i = 0; i < 6; i++)
            {
                if (valores[i]>=0)
                {
                    positivos += 1;                 
                    soma += valores[i];
                }
            }
        }

        public static void CalcMedia()
        {
            media = soma / positivos;
        }

        public static void Mostra()
        {
            Console.WriteLine("{0} valores positivos", positivos);
            Console.WriteLine("A média é {0}", media);
        }         
    }
}


