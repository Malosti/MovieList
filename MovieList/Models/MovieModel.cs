using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public float Rating { get; set; }

        public MovieModel()
        {

        }
        public MovieModel(int id, string name, DateTime date, float rating)
        {
            Id = id;
            Name = name;
            Date = date;
            Rating = rating;
        }

        public void AddMovie()
        {

        }
    }
}
