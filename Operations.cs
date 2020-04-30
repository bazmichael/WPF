using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1
{
    class Operations
    {
        
        private string operation = "";
        private string[] operations = new string[4]
        {
            new string("adding"),
            new string("subtracting"),
            new string("multiplication"),
            new string("dividing")
        };
        public Operations()
        { }

        public void setOperation(string operation_)
        {
            operation = operation_;
        }

        public void clearOperation()
        {
            operation = "";
        }
        public bool operationIsEmpty()
        {
            if (operation == "")
                return true;
            else return false;
        }

        public double operate(string numberOne, string numberTwo)
        {

            double result = 0;

            if (numberTwo == "")
                numberTwo = "0";
            if (operation == operations[0])
                result = Convert.ToDouble(numberOne) + Convert.ToDouble(numberTwo);

            if (operation == operations[1])
                result =  Convert.ToDouble(numberOne) - Convert.ToDouble(numberTwo); 

            if (operation == operations[2])
                result =  Convert.ToDouble(numberOne) * Convert.ToDouble(numberTwo); 

            if (operation == operations[3])
                result = Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo);

            
            return result;
        }

      
    }
}
