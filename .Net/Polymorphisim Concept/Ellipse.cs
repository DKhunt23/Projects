using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    calculating area and volume of Ellipse.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.              
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Ellipse.
    /// </summary>
    internal class Ellipse : Shape
    {
        private double ellipse_major; 
        private double ellipse_minor; 

        /// <summary>
        /// Constructor Ellipse
        /// </summary>
        public Ellipse()
        {
            this.Type = "Three - Dimensional"; 
        }

        /// <summary>
        /// calculating area
        /// </summary>
        /// <returns>a double, area of Ellipse.</returns>
        public override double CalculateArea()
        {
            
            return PI * ellipse_major * ellipse_minor;
        }

        /// <summary>
        /// calculating ellipse volume
        /// </summary>
        /// <returns>a double, volume of ellipse</returns>
        public override double CalculateVolume()
        {
          
            return 4 * PI * ellipse_major * ellipse_minor / 3;
        }

        /// <summary>
        /// user input and storing in class varibales
        /// </summary>
        public override void SetData()
        {
            bool flag = false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the semi-major axis length: ");
                    ellipse_major = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the semi-minor axis length: ");
                    ellipse_minor = double.Parse(Console.ReadLine());
                    // input verification
                    if (ellipse_major < 0 || ellipse_minor < 0)
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
        /// displaying ellipse data
        /// </summary>
        /// <returns> a string, ellipse data</returns>
        public override string ToString()
        {
            return $"Ellipse: {"\nShape type: " + this.Type,-25} {"\n\t[Ellipse semi-major axis: " + ellipse_major,-25} {"Ellipse semi-minor axis: " + ellipse_minor,-25} {"Ellipse Area: " + CalculateArea(),-43} {"Ellipse Volume: " + CalculateVolume()+"]",-43}";
          
        }
    }
}
