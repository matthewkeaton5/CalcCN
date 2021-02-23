using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    public class BulkCalculation
    {
        //store a list of values for bulk operations
        public List<double> ListOfValues { get; set; }
        //store a bulk operations function
        public Func<List<double>, double> BulkOperation { get; set; }
        public BulkCalculation (List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

            //this stores the operation to be performed on A and B
            BulkOperation = calculation;
            
        }
        public static BulkCalculation CreateBulk(List<double> listOfValues, dynamic operation)
        {
            var _calculation = new BulkCalculation(listOfValues, operation);
            return _calculation;
        }
        public double GetResult() 
        {
            return BulkOperation(ListOfValues);
        }
    }
    internal class Create
    {
        private List<double> listOfValues;
        private Func<List<double>, double> operation;

        public Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            this.listOfValues = listOfValues;
            this.operation = operation;
        }
    }

}
