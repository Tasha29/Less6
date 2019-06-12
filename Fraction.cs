using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6
{
    class Fraction
    {

        // поля
        private int numer;
        private int denomi;

        //свойства
        public int Numer { get => numer; set => numer = value; }
        public int Denomi { get => denomi; set => denomi = (value < 0 ? 1 : value); }

        //Конструктор
        public Fraction(int n)
        {
            Numer = n;
            Denomi = 1;
        }

        public Fraction(int n, int d):this(n)
        {
            Denomi = d;
        }

        //методы
        public void ShowFractionInfo()
        {
            Console.WriteLine($"{Numer}/{Denomi}=" + (Numer / (double)Denomi));
        }

        public void ShowFractionReverse()
        {
            Console.WriteLine($"{Denomi}/{Numer}=" + ((double)Denomi / Numer));
        }

        public Fraction GetFractionReverse()
        {
            return new Fraction(Denomi, Numer);
        }

    }
}
