using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    class IncomeTaxCalcCompany : IncomeTaxCalculator
    {
        public int NumberOfEmployees { get; set; }

        public IncomeTaxCalcCompany()
        {

        }
        public IncomeTaxCalcCompany(string name, double annualIncome, int numberofEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberofEmployees;
        }

        public override double TaxCalc()
        {
            double tax;
            if (NumberOfEmployees <= 10)
            {
                tax = (AnnualIncome * 0.16);
                return tax;
            }
            else
            {
                tax = AnnualIncome * 0.14;
                return tax;
            }
        }
    }
}
