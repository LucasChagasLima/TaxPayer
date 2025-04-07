using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer
{
    internal class Individual : TaxPay
    {
        public double HealthExoenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExoenditures) : base(name, anualIncome)
        {
            HealthExoenditures = healthExoenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                AnualIncome *= 0.15;
            }
            else
            {
                AnualIncome *= 0.25;
            }

            if(HealthExoenditures > 0)
            {
                AnualIncome -= HealthExoenditures / 2;
            }

            return AnualIncome;

        }
    }
}
