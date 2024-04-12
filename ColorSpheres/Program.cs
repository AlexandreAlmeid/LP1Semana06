using System;
using System.Runtime.Intrinsics.X86;

namespace ColorSpheres
{
    class Color
    {
        private short Red;
        private short Green;
        private short Blue;
        private short Alpha;

        public Color(short r, short g, short b, short a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }
        public Color(short r, short g, short b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }
        public short GetRed()
        {
            return Red;
        }
        public short GetGreen()
        {
            return Green;
        }
        public short GetBlue()
        {
            return Blue;
        }
        public short GetAlpha()
        {
            return Alpha;
        }
        public int GetGrey()
        {
            return (Red + Green + Blue)/3;
        }
    }
    class Sphere
    {
        private Color Cor;
        private int Raio;
        private int Num;
    
        public Sphere(Color cor, int raio)
        {
            Cor = cor;
            Raio = raio;
            Num = 0;
        }
        public void Pop()
        {
            Raio = 0;
        }
        public void Throw()
        {
            if (Raio > 0)
            {
                Num = Num + 1;
            }
        }
        public int GetTimesThrown()
        {
            return Num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color azul = new Color(0, 0, 255);
            Color vermelho = new Color(255, 0, 0, 33);

            Sphere s1 = new Sphere(azul, 10);
            Sphere s2 = new Sphere(vermelho, 15);

            Console.WriteLine($"Esfera 1 atirada {s1.GetTimesThrown()} vezes.");
            Console.WriteLine($"Esfera 2 atirada {s2.GetTimesThrown()} vezes.");
            s1.Throw();
            s1.Throw();
            s2.Throw();
            s2.Throw();
            s2.Throw();
            Console.WriteLine($"Esfera 1 atirada {s1.GetTimesThrown()} vezes.");
            Console.WriteLine($"Esfera 2 atirada {s2.GetTimesThrown()} vezes.");
            s2.Pop();
            s1.Throw();
            s2.Throw();
            Console.WriteLine($"Esfera 1 atirada {s1.GetTimesThrown()} vezes.");
            Console.WriteLine($"Esfera 2 atirada {s2.GetTimesThrown()} vezes.");
        }
    }
}
