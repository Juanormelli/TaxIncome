using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    abstract class IncomeTaxCalculator
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public IncomeTaxCalculator()
        {

        }
        public IncomeTaxCalculator(string name,double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxCalc();


        
    }
}
