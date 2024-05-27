using System;
using System.Collections.Generic;
using System.Text;
using InflaNET.Models;


namespace InflaMaster
{
    class Program
    {
        //TODO
        //calcular salario
        static void Main(string[] args)
        {

            InflaNET.Models.InflaNET inf = new InflaNET.Models.InflaNET();
            
            Messager.PrintIntro();

            inf.MonthsRange = Parser.ParseToInt();

            Messager.AskForInflationData();

            inf.CalcularInflacion();

            Messager.PrintInflationResult(inf);

            if (Messager.AskToCalculateSalary())
            {
                Messager.AskForSalary();
                inf.SalarioBruto = Parser.ParseToInt();
                inf.CalcularSalario();
                Messager.PrintSalaryResult(inf);

            }

            Console.ReadLine();
        }
    }
}
