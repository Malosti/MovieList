using System;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Year")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Rate the movie is mandatory, please choose a grade between 0 and 10")]
        [DisplayFormat(DataFormatString = "{0} / 10")]
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
