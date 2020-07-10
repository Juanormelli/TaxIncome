using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    class IncomeTaxCalcIndividual : IncomeTaxCalculator
    {
        public double CostsWithHealth { get; set; }

        public IncomeTaxCalcIndividual()
        {

        }

        public IncomeTaxCalcIndividual(string name, double annualIncome, double costsWithHealth) : base(name, annualIncome)
        {
            CostsWithHealth = costsWithHealth;
        }

        public override double TaxCalc()
        {
            double tax;
            if (AnnualIncome < 2000.0)
            {
                tax = (AnnualIncome * 0.15) - (CostsWithHealth * 0.50);
                return tax;

            }
            else
            {
                tax = (AnnualIncome * 0.25) - (CostsWithHealth * 0.50);
                return tax;
            }
        }


    }
}
