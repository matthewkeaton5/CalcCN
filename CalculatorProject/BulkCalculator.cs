using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class BulkCalculator
    {
        public List<BulkCalculation> BulkCalculations = new List<BulkCalculation>();

        public BulkCalculator() { }

        public BulkCalculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            CreateCalculation(listOfValues, _operation);

        }
        public BulkCalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {

            var _calculation = BulkCalculation.CreateBulk(listOfValues, operation);

            return _calculation;
        }
        public void AddCalculation(BulkCalculation _calculation)
        {
            BulkCalculations.Add(_calculation);
        }

    }
}
