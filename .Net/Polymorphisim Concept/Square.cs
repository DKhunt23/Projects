using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    Calculating area and volume of Square.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.             
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Calculating area and volume of Square.
    /// </summary>
    internal class Square : Rectangle
    {
        private double square_length = 0; 

        /// <summary>
        /// Constructor Square
        /// </summary>
        public Square()
        {
            this.Type = "Two - Dimensional"; 
        }

        /// <summary>
        /// 
        /// Calculate area
        /// </summary>
        /// <returns>a double, area of square.</returns>
        public override double CalculateArea()
        {
            return square_length * square_length;
        }

        /// <summary>
        /// Square doesnot have volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// user input and storing in varibales
        /// </summary>
        public override void SetData()
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter the length: ");
                    double square_lengthuser = double.Parse(Console.ReadLine());
                    square_length = square_lengthuser;
                    // input verification
                    if (square_length < 0)
                    {
                        //error message
                         Console.WriteLine("\tPlease enter positive number");
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                catch (FormatException) 
                {
                    //error message
                    Console.WriteLine("\tPlease enter number");
                    flag = false;
                }
            } while (flag != true); 

        }

        /// <summary>
        /// displaying square data
        /// </summary>
        /// <returns> a string, square data</returns>
        public override string ToString()
        {
            return $"Square: {"\nShape type: " + this.Type,-25} {"\n\t[Square Length: " + square_length,-25} {"Square Area: " + CalculateArea()+"]",-43}";
        }
    }
}
