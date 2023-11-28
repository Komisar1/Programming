using System;

namespace AverkievLR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, g, h;
            #region PrisvoenieZnacheniyaPeremennoyNabrannoyIzSochetaniyaDrugihPeremennih
            a = (2.7 - 0.8) * ((3 * 2 + 1) / 3f);
            b = (5.2 - 1.4) / (3f / 7f);
            c = (a / b) - 2.625;
            d = c + ((11 * 8 + 9) / 11f);
            e = (7f / (30 - (18 * 93 + 5) / 18f)) * ((4 * 2 + 1) / 4f);
            f = e / 0.2f;
            g = d - f + Math.Pow(Math.PI, 1f / 6f);
            #endregion
            #region PrisvoenieZnacheniyaOdnoyPeremennoy
            h = (((2.7 - 0.8) * ((3 * 2 + 1) / 3f)) / ((5.2 - 1.4) / (3f / 7f))) - 2.625 + ((11 * 8 + 9) / 11f) - (((7f / (30 - (18 * 93 + 5) / 18f)) * ((4 * 2 + 1) / 4f) / 0.2f)) + Math.Pow(Math.PI, 1f / 6f);
            #endregion

            Console.WriteLine("Присвоение значения всего арифметического выражения одной переменной: " + h );
            Console.WriteLine("Присвоение значения переменной, набранной из сочетания других переменных: " + g);
        }
    }
}
