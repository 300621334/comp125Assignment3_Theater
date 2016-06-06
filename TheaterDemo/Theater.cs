using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    class Theater
    {
        public string Name { get; private set; }
        public List<Show> Shows { get; private set; }
        public Theater(string name)
        { Name = name; Shows = new List<Show>(); }


        public void AddShow(Show show)
        { Shows.Add(show); }

        public void PrintShows()
        { foreach (Show x in Shows) { Console.WriteLine(x); } }

        public void PrintShows(MovieDay day)
        { foreach (Show x in Shows) { if (x.Day == day) { Console.WriteLine(x); } } }

//For time; Only x.Time == time own't work as it will chk whether two are objects of same type, BUT will NOT compare actual value of time. So put .Hours to compare Hours of both.
        public void PrintShows(Time time)
        { foreach (Show x in Shows) { if (x.Time.Hours == time.Hours) { Console.WriteLine(x); } } }

        public void PrintShows(MovieGenre genre)
        { foreach (Show x in Shows) { if (x.Movie.Genre == genre) { Console.WriteLine(x); } } }

        public void PrintShows(string actor)
        { foreach (Show x in Shows) { if (x.Movie.Cast.Contains(actor)) { Console.WriteLine(x); } } }

    }
}


