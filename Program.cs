using System;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace ConsoleApp4 {
    class Program {
        public static object Provider { get; private set; }

        static void Main(string[] args) {
            var wb = new XLWorkbook(@"pasta1.xlsx");
            var planilha = wb.Worksheet(1);

            List<Pessoa> plist = new List<Pessoa>();
            Pessoa pessoa;

            Console.WriteLine("".PadRight('-'));
            Console.WriteLine("Gender".PadRight(20) + "GivenName".PadRight(20) + "MiddleInitial".PadLeft(10) + "SurName".PadLeft(14) + "Age".PadLeft(16));
            Console.WriteLine("".PadRight(100, '-'));
            var linha = 2;
            while (true) {
                var gender = planilha.Cell("A" + linha.ToString()).Value.ToString();
                var givename = planilha.Cell("B" + linha.ToString()).Value.ToString();
                var middleinital = planilha.Cell("C" + linha.ToString()).Value.ToString();
                var surame = planilha.Cell("D" + linha.ToString()).Value.ToString();
                var age = planilha.Cell("E" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(givename)) break;

                pessoa = new Pessoa(gender, givename, middleinital, surame, age);
                plist.Add(pessoa);

                linha++;
            }
            plist.Sort();


            foreach (Pessoa A in plist) {
                Console.WriteLine(A);
            }



            planilha.Dispose();
            wb.Dispose();
            Console.WriteLine("".PadRight(100, '-'));
            Console.WriteLine("By Jonathan Miranda de Moraes");
            Console.ReadKey();

        }
    }
}
