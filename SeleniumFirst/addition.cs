using System;

namespace FillOutForm_tests
{
    class Calculation
    {
        public static int Addition(String expression)
        {
            String[] expressionSplit = expression.Split(); 
            var firstNumber = int.Parse(expressionSplit[0]);
            var secondNumber = int.Parse(expressionSplit[expressionSplit.Length - 1]);
            return firstNumber + secondNumber;
        }


    }

}