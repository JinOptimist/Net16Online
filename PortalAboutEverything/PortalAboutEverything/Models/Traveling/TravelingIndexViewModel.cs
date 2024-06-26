﻿using PortalAboutEverything.Data.Enums;

namespace PortalAboutEverything.Models.Traveling
{
    public class TravelingIndexViewModel
    {
        public List<DateTime> TravelingDates { get; set;} = new List<DateTime>();
        public  bool IsTravingAdmin { get; set;}
    }
}
