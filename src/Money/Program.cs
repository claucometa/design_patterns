using System;
using System.Globalization;
using System.Text;

namespace Claucometa.DesignPatterns.Money
{
    public class Program
    {
        public static void Run()
        {
            var x = new StringBuilder();

            var pt = new CultureInfo("pt");

            var money = new Core.Money();
            x.AppendLine(money.ParseExtenso("200.012.042,01", pt));
            x.AppendLine(money.ParseExtenso("10,012,042.01"));
            x.AppendLine(money.ParseExtenso("1,012,042.01"));
            x.AppendLine(money.ParseExtenso("1.000"));
            x.AppendLine(money.ParseExtenso("1.00"));
            x.AppendLine(money.ParseExtenso("0,01", pt));
            x.AppendLine(money.ParseExtenso("0.01"));

            Console.WriteLine(x.ToString());
        }

    }
}
