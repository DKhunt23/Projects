using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:   Calculating Area and Volume of a Box.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.            
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Calculating area and volume  
    /// </summary>
    internal class Box : Shape
    { 
        private double box_length;
        private double box_width;
        private double box_height;

        /// <summary>
        /// Constructor Box
        /// </summary>
        public Box()
        {
            this.Type = "Three - Dimensional";
        }

        /// <summary>
        /// calculating area
        /// </summary>
        /// <returns>a double,area of box.</returns>
        public override double CalculateArea()
        {
           
            return 2 * (box_length * box_width) + 2 * (box_length * box_height) + 2 * (box_height * box_width);
        }

        /// <summary>
        /// calculating box volume
        /// </summary>
        /// <returns>a double, volume of box.</returns>
        public override double CalculateVolume()
        {
            return box_length * box_height * box_width;
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
                    box_length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width: ");
                    box_width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    box_height = double.Parse(Console.ReadLine());
                    //input verification
                    if(box_length < 0 || box_width < 0 || box_height < 0)
                    {
                        //error message
                        Console.WriteLine("\t Please enter positive number");
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                catch (FormatException) // if input is characters
                {
                    //error message
                    Console.WriteLine("\tPlease enter numbers");
                    flag = false;
                }
            }while (flag != true); 
            
        }

        /// <summary>
        /// displaying box data
        /// </summary>
        /// <returns> a string, box data</returns>
        public override string ToString()
        {
            return $"Box: {"\nShape type: " + this.Type,-25} {"\n\t [Box Length: " + box_length,-25} {"Box Width: " + box_width,-25} {"Box Height: " + box_height,-25} {"Box Area: " + CalculateArea(),-43} {"Box Volumn: " + CalculateVolume()+"]",-43}";

        }
    }
}
