using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    calculating area and volume of Rectangle.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.              
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Rectangle.
    /// </summary>
    internal class Rectangle : Shape
    {
        private double rectangle_length; 
        private double rectangle_width; 

        /// <summary>
        /// Constructor rectangle
        /// </summary>
        public Rectangle()
        {
            this.Type = "Two - Dimensional";
        }

        /// <summary>
        /// calculate area
        /// </summary>
        /// <returns>a double, area of Rectangle.</returns>
        public override double CalculateArea()
        {
            
            return rectangle_length * rectangle_width;

        }

        /// <summary>
        /// calculating volume
        /// </summary>
        /// <returns>a double, volume of rectangle</returns>
        public override double CalculateVolume()
        {
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// user input and storing in  varibales
        /// </summary>
        public override void SetData()
        {
            bool flag = false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the length: ");
                    rectangle_length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width: ");
                    rectangle_width = double.Parse(Console.ReadLine());
                    // input verification
                    if (rectangle_length < 0 || rectangle_width < 0)
                    {
                        // error message
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
            } while(flag != true); 
            
        }

        /// <summary>
        /// displaying rectangle data
        /// </summary>
        /// <returns> a string, rectangle data</returns>
        public override string ToString()
        {
            return $"Rectangle: {"\nShape type: " + this.Type,-25} {"\n\t[Rectangle Length: " + rectangle_length,-25} {"Rectangle Width: " + rectangle_width,-25} {"Rectangle Area: " + CalculateArea()+"]",-43}";
        }
    }
}
