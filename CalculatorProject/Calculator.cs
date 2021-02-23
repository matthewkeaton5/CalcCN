using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public List<Calculation> Calculations = new List<Calculation>();


        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }

        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            CreateCalculation(a, b, _operation);

        }
        public Calculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            
            var _calculation =  Calculation.CreateCalc(a, b, _operation);

            return _calculation;

        }

        public void addCalculation(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }
        public void Calculate(double a, double b, dynamic op)
        {
            CreateCalculation(a, b, op);

        }
    }
}
