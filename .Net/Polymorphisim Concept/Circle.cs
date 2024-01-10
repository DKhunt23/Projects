using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    Calculating Area and Volume of Circle.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.                      
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Circle.
    /// </summary>
    internal class Circle : Ellipse
    {
        private double circle_radius; 

        /// <summary>
        /// Constructor Circle
        /// </summary>
        public Circle()
        {
            this.Type = "Two - Dimensional";

        }

        /// <summary>
        /// Calculating area
        /// </summary>
        /// <returns>a double,area of circle.</returns>
        public override double CalculateArea()
        {
           
            return PI * circle_radius * circle_radius;
        }

        /// <summary>
        /// Circle doesnot have voulme
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
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
                    Console.WriteLine("Enter the radius: ");
                    circle_radius = double.Parse(Console.ReadLine());
                    // input verification
                    if (circle_radius < 0) 
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
        ///displaying circle data
        /// </summary>
        /// <returns> a string, circle data</returns>
        public override string ToString()
        {
            return $"Circle: {"\nShape type: " + this.Type,-25} {"\n\t[Circle Radius: " + circle_radius,-25} {"Circle Area: " + CalculateArea()+"]",-43}";
        }
    }
}
