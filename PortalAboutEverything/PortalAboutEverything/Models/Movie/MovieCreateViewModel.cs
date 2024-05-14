﻿using System.ComponentModel.DataAnnotations;

namespace PortalAboutEverything.Models.Movie
{
    public class MovieCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseDate { get; set; }
        public string Director { get; set; }
        public int Budget { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}