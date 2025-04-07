
namespace TaxPayer
{
    abstract class TaxPay
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPay()
        {
        }
        public TaxPay(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
