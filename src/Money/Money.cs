using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Claucometa.DesignPatterns.Money.Core
{
    public class Money
    {
        public string ParseExtenso(string valor, CultureInfo info = null)
        {
            var culture = Thread.CurrentThread.CurrentCulture;

            var temp = culture;
            if (info != null) culture = info;

            var sepNumperGroup = culture.NumberFormat.NumberGroupSeparator;
            var sepDecimal = culture.NumberFormat.NumberDecimalSeparator;

            var valorTester = valor.Replace(sepNumperGroup, "");

            if (!decimal.TryParse(valorTester, out decimal _))
            {
                throw new FormatException("Input valor tring not in a correct format");
            }

            var numeral = int.Parse(valor.Split(sepDecimal)[0].Replace(sepNumperGroup, ""));
            var temNumeral = numeral > 0;
            var ehPlural = numeral > 1;
            var temp1 = valor.Split(sepDecimal)[1];

            var cents = int.Parse(temp1);
            var temCentavos = cents > 0;
            var ehPluralDecimal = cents > 1;

            var blocos = valor.Split(new string[] { sepNumperGroup, sepDecimal }, StringSplitOptions.None);

            var txtLiteral = new List<string>();

            var magnitude = blocos.Length;
            var ehDezAcionado = false;

            foreach (var numero in blocos)
            {
                var x = new List<string>();
                var num = numero.ToString().PadLeft(3, '0');
                var plural = false;
                var ehDez = false;
                ehDezAcionado = false;

                for (int i = 2; i >= 0; i--)
                {
                    var n = int.Parse(num[2 - i].ToString());
                    if (n > 0)
                    {
                        var u = Dics.Magnetude(i)[n - 1];
                        if (ehDez)
                        {
                            ehDez = false;
                            x[^1] = Dics.teens[n - 1];
                            ehDezAcionado = true;
                        }
                        else
                        {
                            x.Add(u);
                        }
                        ehDez = u == "dez";
                    }
                    plural = n > 1;
                }

                if (magnitude > 2)
                {
                    x[^1] += " " + (plural ? Dics.milhares_plural[magnitude - 3] : Dics.milhares[magnitude - 3]);
                }

                x.Reverse();

                if (x.Count > 0)
                {
                    x[0] += ", ";
                    txtLiteral.InsertRange(0, x);
                }

                magnitude--;
            }

            var nomeMoeda = ehPlural ? "reais" : "real";
            var nomeDecimal = ehPluralDecimal ? "centavos" : "centavo";

            txtLiteral.Reverse();

            if (temNumeral)
            {

                if (txtLiteral.Count == 1)
                {
                    txtLiteral.Insert(txtLiteral.Count, nomeMoeda);
                    //Console.WriteLine("{0}", valor);
                }
                else
                {
                    var fator = temCentavos ? (ehDezAcionado ? 1 : 2) : 0;
                    //Console.WriteLine("{0} - {1}", valor, fator);
                    if (temCentavos && blocos.Length == 2)
                        fator = 1;

                    txtLiteral.Insert(txtLiteral.Count - fator, nomeMoeda);
                }
            }

            var result = string.Join(" e ", txtLiteral.ToArray());

            if (temCentavos) result += $" {nomeDecimal}";

            result = result.Replace(",  e", ",").Replace($", {nomeMoeda}", $" {nomeMoeda}").Replace($",  {nomeDecimal}", $" {nomeDecimal}");

            if (!temNumeral)
                result = result.Replace($"{nomeMoeda} e ", null);

            if (!temCentavos)
            {
                var i = result.LastIndexOf(',');
                if (i > 0)
                {
                    result = result.Remove(i, 1);
                    result = result.Insert(i, " e");
                }
            }

            Thread.CurrentThread.CurrentCulture = temp;

            return result;
        }
    }
}
