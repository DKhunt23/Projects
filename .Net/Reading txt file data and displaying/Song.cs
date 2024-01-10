/*
 * Author: Dipsa Khunt
 * Date: 30 Oct 2022
 * This Class: Song.cs (Child Class)
 * Parent Class: Media.cs
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
    internal class Song : Media
    {
        //artist of song
        public string artist { get; private set; }

        //album of song
        public string album { get; private set; }

        /// <summary>
        /// Constructor, set default values
        /// </summary>
        /// <param name="title">The title of the song</param>
        /// <param name="year">The year of release of the song</param>
        ///<param name="artist">The Artist of the song</param>
        /// <param name="album">Summary</param>

        public Song(string title, int year, string artist, string album) : base(title, year)
        {
            this.album = album;
            this.artist = artist;
        }

        /// <summary>
        /// tostring
        /// </summary>
        /// <returns> string form of data </returns>

        public override string ToString()
        {
            return "Song " + "\nTitle: " + Title + "\nYear: " + Year + "Album: " + album + "\n" + "Artist: " + artist + "\n\n";
        }
    }
}
