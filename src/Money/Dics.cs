namespace Claucometa.DesignPatterns.Money.Core
{
    internal static class Dics
    {
        public static string[] Magnetude(int x)
        {
            if (x == 0) return unidades;
            if (x == 1) return dezenas;
            if (x == 2) return centenas;
            return milhares;
        }
     
        public static string[] unidades = new string[]
        {
          "um" ,
          "dois" ,
          "três" ,
          "quatro" ,
          "cinco" ,
          "seis" ,
          "sete" ,
          "oito" ,
          "nove" ,
        };

        public static string[] teens = new string[]
       {
            "onze" ,
            "doze" ,
            "treze" ,
            "quatorze" ,
            "quinze" ,
            "dezesseis" ,
            "dezesete" ,
            "dezoito" ,
            "dezenove" ,
       };

        public static string[] dezenas = new string[]
        {
            "dez" ,
            "vinte" ,
            "trinta" ,
            "quarenta" ,
            "cinquenta" ,
            "sessenta" ,
            "setenta" ,
            "oitenta" ,
            "noventa" ,
        };

        public static string[] centenas = new string[]
        {
             "cem" ,
             "duzentos" ,
             "trezentos" ,
             "quatrocentos" ,
             "quinhentos" ,
             "seiscentos" ,
             "setecentos" ,
             "oitocentos" ,
             "novecentos" ,
        };

        public static string[] milhares = new string[]
        {
           "mil" ,
           "milhão" ,
           "trilhão" ,
           "quatrilhão" ,
           "quintilhão" ,
           "sextilhão" ,
           "septilhão" ,
        };

        public static string[] milhares_plural = new string[]
     {
           "mil" ,
           "milhões" ,
           "trilhões" ,
           "quatrilhões" ,
           "quintilhões" ,
           "sextilhões" ,
           "septilhões" ,
     };
    }
}
