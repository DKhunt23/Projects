using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    calculating area and volume of Cylinder.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.             
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// calculating area and volume of Cylinder.
    /// </summary>
    internal class Cylinder : Shape
    {
        private double cylinder_height; 
        private double cylinder_radius; 

        /// <summary>
        /// Constructor Cylinder
        /// </summary>
        public Cylinder()
        {
            this.Type = "Three - Dimensional"; 
        }

        /// <summary>
        /// calculating area
        /// </summary>
        /// <returns>a double, area of cylinder.</returns>
        public override double CalculateArea()
        {
          
            return 2 * PI * cylinder_radius * cylinder_height + 2 * PI * cylinder_radius * cylinder_radius;
        }

        /// <summary>
        /// calculating cylinder volume
        /// </summary>
        /// <returns>a double, volume of cylinder</returns>
        public override double CalculateVolume()
        {
            
            return PI * cylinder_radius * cylinder_radius * cylinder_height;
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
                    Console.WriteLine("Enter the radius: ");
                    cylinder_radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    cylinder_height = double.Parse(Console.ReadLine());
                    // input verification
                    if (cylinder_radius < 0 || cylinder_height < 0)
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
        /// displaying cylinder data
        /// </summary>
        /// <returns> a string, cylinder data</returns>
        public override string ToString()
        {
            return $"Cylinder: {"\nShape type: " + this.Type,-25} {"\n\t[Cylinder Radius: " + cylinder_radius,-25} {"Cylinder Height: " + cylinder_height,-25} {"Cylinder Area: " + CalculateArea(),-43} {"Cylinder Volume: " + CalculateVolume()+"]",-43}";
        }
    }
}
