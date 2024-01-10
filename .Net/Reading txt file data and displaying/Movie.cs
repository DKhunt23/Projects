/*
 * Author: Dipsa Khunt
 * Date: 30 Oct 2022
 * This Class: Movie.cs (Child Class)
 * Parent Class: Media.cs
 * Implemented Class: IEncryptable
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// <summary>
/// Purpose of this class: create the object of movie 
/// </summary>
namespace Lab3A
{
    internal class Movie : Media, IEncryptable
    {
        // director of the movie
        public string director { get; private set; }

        //summary of movie
        public string summary { get; private set; }

        /// <summary>
        /// Constructor, set default values
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="year">The year of release of the song</param>
        ///<param name="director">The director of the movie</param>
        /// <param name="summary">Summary</param>
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            this.director = director;
            this.summary = summary;
        }

        /// <summary>
        /// Encrypt, rot13 algorithm
        /// reference:https://thedeveloperblog.com/rot13
        /// </summary>
        /// <returns>Encrypted summary</returns>

        public string Encrypt()
        {

            char[] encryptsummary = summary.ToCharArray();
            for (int i = 0; i < encryptsummary.Length; i++)
            {
                int number = (int)encryptsummary[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                encryptsummary[i] = (char)number;
            }
            return new string(encryptsummary);
        }

        /// <summary>
        /// Decrypt, rot13 algorithm
        /// reference:https://thedeveloperblog.com/rot13
        /// </summary>
        /// <returns>Decrypted summary</returns>

        public string Decrypt()
        {
            char[] decrptsummary = summary.ToCharArray();
            for (int i = 0; i < decrptsummary.Length; i++)
            {
                int number = (int)decrptsummary[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                decrptsummary[i] = (char)number;
            }
            return new string(decrptsummary);

        }

        /// <summary>
        /// tostring
        /// </summary>
        /// <returns>string form of movie data</returns>
        public override string ToString()
        {
            return "Movie " + "\nTitle: " + Title + "\nYear: " + Year + "\nDirector: " + director + "\n\nSummary: " + Decrypt() + "\n\n";
        }

    }
}
