﻿using PortalAboutEverything.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace PortalAboutEverything.Models.History
{
    public class HistoryUpdateViewModel
    {
        public int Id { get; set; }
        [Required()]
        [HistoryEventName]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required()]
        [HistoryEventYear]
        public int YearOfEvent { get; set; }
    }
}

