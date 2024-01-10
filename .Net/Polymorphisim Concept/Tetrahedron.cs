using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    Calculate area and volume of Tetrahedron.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.              
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Calculate area and volume of Tetrahedron.
    /// </summary>
    internal class Tetrahedron : Triangle
    {
        private double tetrahedron_length; 

        /// <summary>
        /// Constructor Tetrahedron
        /// </summary>
        public Tetrahedron()
        {
            this.Type = "Three - Dimensional"; 

        }

        /// <summary>
        /// Calculate area
        /// </summary>
        /// <returns>a double, area of trtrahedron.</returns>
        public override double CalculateArea()
        {
        
            return Math.Sqrt(3) * (tetrahedron_length * tetrahedron_length);
        }

        /// <summary>
        /// Calculate volume of tetrahedron
        /// </summary>
        /// <returns>a double, volume of tetrahedron</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(tetrahedron_length, 3) / 6 * Math.Sqrt(2);
        }

        /// <summary>
        /// user input and store in varibales
        /// </summary>
        public override void SetData()
        {
            bool flag = false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the length: ");
                    tetrahedron_length = double.Parse(Console.ReadLine());
                    // input verification
                    if (tetrahedron_length < 0)
                    {
                        //error message
                         Console.WriteLine("\tPlease enter positive numbers");
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
        /// Displaying tetrahedron data
        /// </summary>
        /// <returns> a string, tetrahedron data</returns>
        public override string ToString()
        {
            return $"Tetrahedron: {"\nShape type: " + this.Type,-25} {"\n\t[Tetrahedron Length: " + tetrahedron_length,-25} {"Tetrahedron Area: " + CalculateArea(),-43} {"Tetrahedron Volume: " + CalculateVolume()+"]",-43}";    
        }
    }
}
