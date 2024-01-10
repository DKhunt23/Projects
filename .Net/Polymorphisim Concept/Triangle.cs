using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    calculating area and volume of Triangle.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.              
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Triangle.
    /// </summary>
    internal class Triangle : Shape
    {
        private double triangle_height; 
        private double triangle_base; 

        /// <summary>
        /// Constructor Triangle
        /// </summary>
        public Triangle()
        {
            this.Type = "Two - Dimensional"; 
        }

        /// <summary>
        /// calculating area
        /// </summary>
        /// <returns>a double, area of triangle.</returns>
        public override double CalculateArea()
        {
            return triangle_base * triangle_height / 2;
        }

        /// <summary>
        /// triangle doesnot have volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// user input from and storing in varibales
        /// </summary>
        public override void SetData()
        {
            bool flag = false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the base: ");
                    triangle_base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    triangle_height = double.Parse(Console.ReadLine());
                    //input verification
                    if (triangle_base < 0 || triangle_height < 0)
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
        /// displaying triangle data
        /// </summary>
        /// <returns> a string, triangle data</returns>
        public override string ToString()
        {
            return $"Triangle: {"\nShape type: " + this.Type,25} {"\n\t[Triangle Base: " + triangle_base,-25} {"Triangle Height: " + triangle_height,-43} {"Triangle Area: " + CalculateArea()+"]",-43}";
        }
    }
}
