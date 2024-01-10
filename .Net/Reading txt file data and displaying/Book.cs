/*
 * Author: Dipsa Khunt
 * Date: 30 Oct 2022
 * This Class: Book.cs(Child class)
 * Parent Class: Media.cs
 * Implemented Class: IEncryptable
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose of this class: create the object of the song 
/// </summary>
namespace Lab3A
{
    internal class Book : Media, IEncryptable
    {
        //author of the book
        public string author { get; private set; }

        //summary of book
        public string summary { get; private set; }

        
        public Book(string title, int year, string Author, string Summary) : base(title, year)
        {
            this.author = Author;
            this.summary = Summary;
        }

        /// <summary>
        /// Encrypt,rot13 algorithm
        /// reference:https://thedeveloperblog.com/rot13
        /// </summary>
        /// <returns>Encrypted summary</return>

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
        /// <returns>string form of book data</returns>
        public override string ToString()
        {
            return "BOOK " + "\nTitle: "+ Title +"\nYear: "+Year+ "\nAuthor: " + author + "\n\nSummary: " + Decrypt() + "\n\n";
        }
    }
}
