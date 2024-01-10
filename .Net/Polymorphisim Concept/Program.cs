using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Purpose:   View class to interact with user.
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.            
/// </summary>
namespace Lab2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List to store all the shapes 
            List<Shape> shapelist = new List<Shape>();
            char choice = 'K'; 
            
            do
            {
                Console.Clear();
                //Displaying the menu to user
                Console.WriteLine("Dipsa's Geometry Class");
                Console.WriteLine("A - Rectangle \t E - Ellipse \t I - Triangle");
                Console.WriteLine("B - Square \t F - Circle \t J - Tetrahedron");
                Console.WriteLine("C - Box \t G - Cylinder");
                Console.WriteLine("D - Cube \t H - Sphere");

                Console.WriteLine("\n0 - List all shapes and Exit ...");
                bool flag = false; 
                do
                {
                    try
                    {
                        Console.Write("\nEnter Your Choice: ");
                        choice = char.Parse(Console.ReadLine());
                        flag = true;
                    }
                    //input verification
                    catch (Exception) 
                    {
                        //error message
                        Console.WriteLine("\n\tPlease enter only Character");
                        flag = false;
                    }
                } while (flag != true); 

                // counting and displaying the number of shapes user enter value
                Console.WriteLine("\n" + Shape.GetCount() + "(shapes enter so far) \n");

                try
                {
                    // switch to class each class
                    switch (char.ToUpper(choice))
                    {
                        case 'A':
                            Shape rectangle = new Rectangle();
                            rectangle.SetData();
                            shapelist.Add(rectangle);
                            break;
                        case 'B':
                            Shape square = new Square();
                            square.SetData();
                            shapelist.Add(square);
                            break;
                        case 'C':
                            Shape box = new Box();
                            box.SetData();
                            shapelist.Add(box);
                            break;
                        case 'D':
                            Shape cube = new Cube();
                            cube.SetData();
                            shapelist.Add(cube);
                            break;
                        case 'E':
                            Shape ellipse = new Ellipse();
                            ellipse.SetData();
                            shapelist.Add(ellipse);
                            break;
                        case 'F':
                            Shape circle = new Circle();
                            circle.SetData();
                            shapelist.Add(circle);
                            break;
                        case 'G':
                            Shape cylinder = new Cylinder();
                            cylinder.SetData();
                            shapelist.Add(cylinder);
                            break;
                        case 'H':
                            Shape sphere = new Sphere();
                            sphere.SetData();
                            shapelist.Add(sphere);
                            break;
                        case 'I':
                            Shape triangle = new Triangle();
                            triangle.SetData();
                            shapelist.Add(triangle);
                            break;
                        case 'J':
                            Shape tetrahedron = new Tetrahedron();
                            tetrahedron.SetData();
                            shapelist.Add(tetrahedron);
                            break;
                        case '0':
                            Console.WriteLine("\n\n\n\n");
                            Console.WriteLine("\t\t\t----------------------------Shapes You Entered--------------------------------- \n");
                            foreach (var i in shapelist)
                            {
                                Console.WriteLine(i.ToString() + "\n");
                            }
                            Thread.Sleep(300000);
                            break;
                    }
                }
                catch (FormatException) // if user enter numbers or string
                {
                    Console.WriteLine("\tPlease Enter Characters Only");
                }
            } while (choice != '0'); 
        }
    }
}
