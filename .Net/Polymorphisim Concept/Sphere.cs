using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    Calculating area and volume of Sphere.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.              
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Calculating area and volume of Sphere.
    /// </summary>
    internal class Sphere : Cylinder
    {
        private double sphere_radius; 

        /// <summary>
        /// Constructor Sphere
        /// </summary>
        public Sphere()
        {
            this.Type = "Three - Dimensional"; 
        }

        /// <summary>
        /// calculate area
        /// </summary>
        /// <returns>a double, area of sphere.</returns>
        public override double CalculateArea()
        {
           
            return 4 * PI * sphere_radius * sphere_radius;
        }

        /// <summary>
        /// calculating volume
        /// </summary>
        /// <returns>a double, volume of sphere</returns>
        public override double CalculateVolume()
        {
            
            return 4 * PI * sphere_radius * sphere_radius * sphere_radius / 3;
        }

        /// <summary>
        /// user input and storing in varibales
        /// </summary>
        public override void SetData()
        {
            bool flag=false; 
            do
            {
                try
                {
                    Console.WriteLine("Enter the radius: ");
                    sphere_radius = double.Parse(Console.ReadLine());
                    // input verification
                    if (sphere_radius < 0)
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
        /// displaying sphere data
        /// </summary>
        /// <returns> a string, sphere data</returns>
        public override string ToString()
        {
            return $"Sphere: {"\nShape type: " + this.Type,-25} {"\n\t[Sphere Radius: " + sphere_radius,-25} {"Sphere Area: " + CalculateArea(),-43} {"Sphere Volume: " + CalculateVolume()+"]",-43}";
        }
    }
}
