using IncomeTax.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IncomeTaxCalculator> IncomeTax = new List<IncomeTaxCalculator>();
            Console.Write("Enter with Number of contributors: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter Contributor #{i} data");
                Console.Write("Company or Individual (c/i)?: ");
                char CompanyOrIndividual = char.Parse(Console.ReadLine().ToUpper());
                if (CompanyOrIndividual == 'C')
                {
                    Console.Write("Enter Company Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Annual Income: ");
                    double annualincome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Enter number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());
                    IncomeTax.Add(new IncomeTaxCalcCompany(name, annualincome, numberofEmployees));
                }
                else
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Annual Income: ");
                    double annualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Enter Costs With Health: ");
                    double costswithHealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    IncomeTax.Add(new IncomeTaxCalcIndividual(name, annualincome, costswithHealth));
                }
            }
            foreach(IncomeTaxCalculator tax in IncomeTax)
            {
                Console.WriteLine(tax.Name +(": ")+ tax.TaxCalc().ToString("F2"));
            }
        }
    }
}
