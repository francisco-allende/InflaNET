using System;
using System.Collections.Generic;
using System.Text;

namespace InflaNET.Models
{
    public class Messager
    {
        static public void PrintIntro()
        {
            string msj = "\n  *************************************\n" +
                            "  * Calculemos la inflación acumulada *" +
                          "\n  *************************************\n" +
                          "\n Ingresa la cantidad de meses a calcular: \n";

            Console.WriteLine(msj);
        }

        static public void AskForInflationData()
        {
            string msj = "\n Ahora en orden la inflacion de los ultimos  meses. Solo el nro con uno o ningun decimal: \n";
            Console.WriteLine(msj);
        }

        static public void PrintInflationResult(InflaNET inf)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n La inflación acumulada de los ultimos ");
            sb.Append(inf.MonthsRange);
            sb.Append(" meses fue de: ");
            sb.Append(Math.Round(inf.ResultInflaAcumulada, 2));
            sb.Append("%");
            Console.WriteLine(sb.ToString());
        }

        static public bool AskToCalculateSalary()
        {
            string msj = "\n Queres calcular como te queda el salario? s/n \n";
            Console.WriteLine(msj);

            string respuesta = Console.ReadLine().Trim().ToLower();

            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine(" Entrada no válida. Por favor ingresa 's' para sí o 'n' para no:");
                respuesta = Console.ReadLine().Trim().ToLower();
            }

            return respuesta == "s";
        }

        static public void AskForSalary()
        {
            string msj = "\n Ingrese el salario bruto como numero entero \n";
            Console.WriteLine(msj);
        }
        static public void PrintSalaryResult(InflaNET inf)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n El salario BRUTO con el aumento según inflación acumulada queda en: $");
            sb.Append(inf.SalarioBruto);
            sb.Append("\n El salario NETO queda en: $");
            sb.Append(inf.SalarioNeto);
            Console.WriteLine(sb.ToString());
        }
    }
}
