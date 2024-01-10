using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    calculating area and volume of Cube.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.             
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Cube.
    /// </summary>
    internal class Cube : Box
    {
        private double cube_length; 
        /// <summary>
        /// Constructor Cube
        /// </summary>
        public Cube()
        {
            this.Type = "Three - Dimensional"; 
        }

        /// <summary>
        /// calculating area
        /// </summary>
        /// <returns>a double, area of cube.</returns>
        public override double CalculateArea()
        {
            
            return 6 * (cube_length * cube_length);
        }

        /// <summary>
        /// calculating cube volume
        /// </summary>
        /// <returns>a double, volume of cube</returns>
        public override double CalculateVolume()
        {
            
            return cube_length * cube_length * cube_length;
        }

        /// <summary>
        /// user input and storing in variables
        /// </summary>
        public override void SetData()
        {
            bool flag = false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the length: ");
                    cube_length = double.Parse(Console.ReadLine());
                    // input verification
                    if (cube_length < 0)
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
        /// displaying cube data
        /// </summary>
        /// <returns> a string, cube data</returns>
        public override string ToString()
        {
            return $"Cube: {"\nShape type: " + this.Type,-25} {"\n\t[Cube Length: " + cube_length,-25} {"Cube Area: " + CalculateArea(),-43} {"Cube Volume: " + CalculateVolume()+"]",-43}";
        }
    }
}
