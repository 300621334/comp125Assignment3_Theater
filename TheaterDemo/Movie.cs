using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    //http://geekswithblogs.net/BlackRabbitCoder/archive/2010/07/22/c-fundamentals-combining-enum-values-with-bit-flags.aspx
    //http://www.codeducky.org/ins-outs-c-enums/
    //enum w small-letter-"e" --- NOT Cap Enum.
    //[Flags] allows Enum.ToString() to display/print more than 1 enum values seperated by commas.
    //http://stackoverflow.com/questions/9811114/why-do-enum-permissions-often-have-0-1-2-4-values
    //http://stackoverflow.com/questions/1030090/how-do-you-pass-multiple-enum-values-in-c
    //It allows one to store multiple flags in a single field of bits. like 0001 & 0010 both passed just by 0011.etc

    /*It looks for EXACT (using &) match, if found, it displays ONLY that. 
If no EXACT match is found then it uses OR (|) to display ALL that can be 'OR'ed.
Thus if enum had a =33 this very program, instaed of displaying Action, Horror for forst result it will display "Comedy"
{ Unrated=0, Action=1, Romance=2, Documentry=4, Mystry=8, Musical=16, Horror=32, Comedy=33 }*/

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
