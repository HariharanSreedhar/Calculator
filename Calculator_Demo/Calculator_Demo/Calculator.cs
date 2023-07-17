using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Demo
{
    /// <summary>
    /// Calculaator class to peform arithmetic operations
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Method to perform addtion operation
        /// </summary>
        /// <param name="x">input 1</param>
        /// <param name="y">input 2</param>
        /// <returns>addition of 2 inputs</returns>
        public float Addition(float x, float y)
        { 
            return x + y;
        }

        /// <summary>
        /// Method to perform subtraction operation
        /// </summary>
        /// <param name="x">input 1</param>
        /// <param name="y">input 2</param>
        /// <returns>Subtraction of 2 inputs</returns>
        public float Subtraction(float x, float y)
        {
            return x - y;
        }

        /// <summary>
        /// Method to perform multiplication operation
        /// </summary>
        /// <param name="x">input 1</param>
        /// <param name="y">input 2</param>
        /// <returns>Mulitiplication of 2 inputs</returns>
        public float Multiplication(float x, float y)
        {
            return x * y;
        }

        /// <summary>
        /// Method to perform division operation
        /// </summary>
        /// <param name="x">input 1</param>
        /// <param name="y">input 2</param>
        /// <returns>Division of 2 inputs</returns>
        public float Division(float x, float y)
        {
            return x / y;
        }
    }
}
