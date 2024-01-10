using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:    Shape Class is the base class 
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.            
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Shape Class is the base class 
    /// </summary>
    internal abstract class Shape
    {
        public string Type { get; protected set; }         
        private static int count = 0;                      
        protected const double PI = 3.141592653589793;     


        //constructor does is increment the number of Shape instances
        public Shape()
        {
            count++;
        }

        public abstract double CalculateArea();            //Calculate the Shape's area (surface area if 3-d)
        public abstract double CalculateVolume();          //Calculate the Shape's volume (if 3-d)
        public abstract void SetData();                    //Prompts the user for dimensions
        public override string ToString() => "";           //Used for printing Shape data

        //Retrieves the current number of Shape instances
        public static int GetCount()
        {
            return count;
        }
    }
}
