using System;
using System.Collections.Generic;
using System.Text;

namespace InflaNET.Models
{
    public class InflaNET
    {
        public InflaNET()
        {
            InflaMes = new List<decimal>();
        }

        public int MonthsRange { get; set; }
        
        public List<decimal> InflaMes { get; set; }
        public decimal ResultInflaAcumulada { get; set; }
        public int SalarioBruto { get; set; }
        public int SalarioNeto { get; set; }

        public decimal CalcularInflacion()
        {
            for (int i = 0; i < this.MonthsRange; i++)
            {
                this.InflaMes.Add(Parser.GetParsedNum());
                this.InflaMes[i] = 1 + (this.InflaMes[i] / 1000);

                if (i != 0)
                {
                    this.ResultInflaAcumulada *= this.InflaMes[i];
                }
                else
                {
                    this.ResultInflaAcumulada = this.InflaMes[i];
                }
            }
            return this.ResultInflaAcumulada = (this.ResultInflaAcumulada - 1) * 100;
        }

        public void CalcularSalario()
        {
            this.SalarioBruto = (int)(this.SalarioBruto * (1 + this.ResultInflaAcumulada / 100));
            this.SalarioNeto = (int)(this.SalarioBruto * (1 - 17m / 100m));
        }

    }
}
