﻿namespace filmhub.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }
        public string Picture { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public int Rating { get; set; }
    }
}