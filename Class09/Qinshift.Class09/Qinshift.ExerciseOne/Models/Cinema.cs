using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.ExerciseOne.Models
{
   public class Cinema
    {
        public Cinema()
        {
           
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public Cinema(string name)
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }   
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"The movie {movie.Title} is playing!");
        }

    }
}
