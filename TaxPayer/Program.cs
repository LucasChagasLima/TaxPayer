
using System.Globalization;
using TaxPayer;

List<TaxPay> list = new List<TaxPay>();

CultureInfo ci = CultureInfo.InvariantCulture;

Console.Write("ENter The number of Tax Payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax Payer #{n} data: ");
    Console.Write("Individual or Company (i/c)? ");
    char IorC = char.Parse(Console.ReadLine());
    if (IorC == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income : ");
        double anualIncome = double.Parse(Console.ReadLine(), ci);
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), ci);

        list.Add(new Individual (name, anualIncome, healthExpenditures));

    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income : ");
        double anualIncome = double.Parse(Console.ReadLine(), ci);
        Console.Write("Number of Employees: ");
        int numberEmployee = int.Parse(Console.ReadLine());

        list.Add(new Company(name, anualIncome, numberEmployee));

    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");

foreach (TaxPay tax in list)
{
    Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2", ci));
}
Console.WriteLine();
double sum = 0.0;
foreach (TaxPay tax in list)
{
    sum += tax.Tax();
}
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", ci));



