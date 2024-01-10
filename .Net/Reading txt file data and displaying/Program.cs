/*
 * Author: Dipsa Khunt
 * Date: 30 Oct 2022
 * Class: Program.cs
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// I, Dipsa Khunt, 000870839 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// Date: October 30,2022
/// Purpose: The purpose of this assignmnet is to read the data from text file 
/// and display data according to the choice of  user from 6 choices given. 

namespace Lab3A
{
    internal class Program
    {
        //variable using as index for increment
        private static int numberOfMedia;
        //array for storing media parts
        private static string[] mediaparts;
        //media array object of Media
        private static Media[] media = new Media[80];
        //variable for stroing summary
        private static string summary;
        const string DATAFILE = "Data.txt";
        static void Main(string[] args)
        {
            /// <summary>
            /// printing the data
            /// </summary>
            /// <param name="userchoice">choice of the user </param>

            void printMediaData(int userchoice)
            {
                //calling MediaData method for reading data
                mediaData();

                //loop run through length of media
                for (int i = 0; i < numberOfMedia; i++)
                {
                    //displaying data of book 
                    if (media[i] is Book && (userchoice == 1 || userchoice == 4))
                    {
                        Book book = (Book)media[i];
                        Console.WriteLine($"{book.Title,-65} {book.Year,-15} {book.author,-20}");
                    }
                    //displaying data of movie
                    if (media[i] is Movie && (userchoice == 2 || userchoice == 4))
                    {
                        Movie movie = (Movie)media[i];
                        Console.WriteLine($"{movie.Title,-65} {movie.Year,-15} {movie.director,-20}");
                    }
                    //displaying data of song
                    if (media[i] is Song && (userchoice == 3 || userchoice == 4))
                    {
                        Song song = (Song)media[i];
                        Console.WriteLine($"{song.Title,-65} {song.Year,-15} {song.album,-20}");
                    }
                    
                }
                //displaying data of searched string entered by user
                if (userchoice == 5)
                {
                    Console.Write("\nEnter a search String: ");
                    string search = Console.ReadLine();
                    Console.WriteLine("\nList of Media");
                    Console.WriteLine("--------------");
                    for (int j = 0; j < numberOfMedia; j++)
                    {
                        if (media[j].Search(search))
                        {
                            Console.WriteLine("\n"+media[j]);
                        }

                    }
                }
            }
            /// <summary>
            /// Reading the data from data.txt
            /// </summary>
           
            void mediaData()
            {
                
                try
                {
                    numberOfMedia = 0;

                    //Read the file
                    StreamReader reader = new StreamReader(DATAFILE);

                    //loop terminates when end of file is reached
                    while (!reader.EndOfStream)
                    {
                        //storing parts of media seperated by |
                        mediaparts = reader.ReadLine().Split('|');

                            if (mediaparts[0] == "BOOK")
                            {
                                //retriveing summary
                                summary = reader.ReadLine();

                                //storing summary till there is no -----
                                while (reader.ReadLine() != "-----")
                                {
                                    summary += reader.ReadLine();
                                }

                                //storing data in media object array
                                media[numberOfMedia] = new Book(mediaparts[1], int.Parse(mediaparts[2]), mediaparts[3], summary);
                                numberOfMedia++;
                            }

                            if (mediaparts[0] == "SONG")
                            {
                                //storing data in media object array
                                media[numberOfMedia] = new Song(mediaparts[1], int.Parse(mediaparts[2]), mediaparts[3], mediaparts[4]);
                                numberOfMedia++;

                            }
                    
                            if (mediaparts[0] == "MOVIE")
                            {
                                //retriveing summary
                                summary = reader.ReadLine();

                                //storing summary till there is no -----
                                while (reader.ReadLine() != "-----")
                                {
                                    summary += reader.ReadLine();
                                }

                                //storing data in media object array
                                media[numberOfMedia] = new Movie(mediaparts[1], int.Parse(mediaparts[2]), mediaparts[3], summary);
                                numberOfMedia++;
                            }

                    }
                    reader.Close();
                }
                //Exception handling for reading a file
                catch (IOException)
                {
                    Console.WriteLine("File not found!!!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error!!!");
                }
            }

            int choice = 0;
            //loop for program to be continued till user wants to exit
            do
            {
                try
                {
                    //displaying menu
                    Console.WriteLine("\n\n--------Dipsa's Media Collection--------");
                    Console.WriteLine("\t1 - List All Books");
                    Console.WriteLine("\t2 - List All Movies");
                    Console.WriteLine("\t3 - List All Songs");
                    Console.WriteLine("\t4 - List All Media");
                    Console.WriteLine("\t5 - Search All Media by Title");
                    Console.WriteLine("\t6 - Exit");
                    Console.WriteLine("----------------------------------------");

                    //user choice 
                    Console.Write("\n\nPlease Enter Your Choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\nList of Books");
                            Console.WriteLine("**************");
                            Console.WriteLine($"{"Name ",-65} {"Year ",-15} {"Director ",-20}\n");
                            //calling mediaData method
                            printMediaData(1);
                            break;

                        case 2:
                            Console.WriteLine("\n\nList of Movies");
                            Console.WriteLine("**************");
                            Console.WriteLine($"{"Name ",-65} {"Year ",-15} {"Director ",-20}\n");
                            //calling mediaData method
                            printMediaData(2);
                            break;

                        case 3:
                            Console.WriteLine("\n\nList of Songs");
                            Console.WriteLine("**************");
                            Console.WriteLine($"{"Name ",-65} {"Year ",-15} {"Director ",-20}\n");
                            //calling mediaData method
                            printMediaData(3);
                            break;

                        case 4:
                            Console.WriteLine("\n\nList of Media");
                            Console.WriteLine("***************");
                            Console.WriteLine($"{"Name ",-65} {"Year ",-15} {"Director ",-20}\n");
                            //calling mediaData method
                            printMediaData(4);
                            break;

                        case 5:
                            //calling mediaData method
                            printMediaData(5);
                            break;

                        case 6:
                            break;

                        default:
                            Console.WriteLine("****Please enter number between 1 and 6****");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input");
                }


            } while (choice != 6);
        }
    }
}
