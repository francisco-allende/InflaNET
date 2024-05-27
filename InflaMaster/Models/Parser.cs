using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InflaNET.Models
{
    public class Parser
    {
        static public int ParseToInt()
        {
            int month = 0;
            bool isParsed = false;

            do
            {
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if(month <= 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    isParsed = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\nPor favor, ingrese un número superior a 0: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nPor favor, reintente ingresando un número entero: ");
                }
            } while (!isParsed);

            return month;
        }

        static public decimal GetParsedNum()
        {
            decimal num = 0;
            bool isParsed = false;

            do
            {
                try
                {
                    string numStr = Console.ReadLine();
                    
                    if(!numStr.Contains(".") && !numStr.Contains(","))
                    {
                        numStr += ",0";
                    }

                    if (numStr.Contains("."))
                    {
                        numStr = numStr.Replace(".", ",");
                    }

                    num = Convert.ToDecimal(numStr, CultureInfo.InvariantCulture);
                    isParsed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nPor favor, reintente ingresando un número decimal: ");
                }
            } while (!isParsed);

            return num;
        }
    }
}
