﻿using System;
using System.ComponentModel.DataAnnotations;



namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //primary key in db
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }



    }
}
