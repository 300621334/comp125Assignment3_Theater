using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
//enum w small-letter-"e" --- NOT Cap Enum.
//[Flags] allows to pass more than 1 enum values in methods.
//http://stackoverflow.com/questions/9811114/why-do-enum-permissions-often-have-0-1-2-4-values
//http://stackoverflow.com/questions/1030090/how-do-you-pass-multiple-enum-values-in-c
//It allows one to store multiple flags in a single field of bits. like 0001 & 0010 both passed just by 0011.etc



    [Flags] public enum MovieGenre
    { Unrated=0, Action=1, Romance=2, Documentry=4, Mystry=8, Musical=16, Horror=32, Comedy=64 }
    class Movie
    {
        public List<string> Cast { get; private set; }
        public MovieGenre Genre { get; private set; }
        public int Length { get; private set; }
        public string Title { get; private set; }

        //constructor
        public Movie(string t, int l)
        { Title = t; Length = l; Cast = new List<string>();
        }

        public void AddActor(string actor)
        { Cast.Add(actor); }

        public void SetGenre(MovieGenre genre)
        { Genre = genre; }

        public override string ToString()
        {
            string actorNames = "";
            foreach(string x in Cast)
            { actorNames += x + ","; }
            return string.Format("Movie {0} \nDuration: {1} minutes \nGenre:{2} \nFeaturing: {3}", Title, Length, Genre, actorNames);
        }
    }
}
