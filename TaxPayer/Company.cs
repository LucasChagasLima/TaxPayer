

using System.Globalization;

namespace TaxPayer
{
    internal class Company : TaxPay
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }
        
        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if (NumberEmployees < 10)
            {
                AnualIncome *= 0.16;
            }
            else
            {
                AnualIncome *= 0.14;

            }

            return AnualIncome;

        }
    }
}
