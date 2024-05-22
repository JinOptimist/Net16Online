﻿namespace PortalAboutEverything.Models.BoardGame
{
    public class BoardGameViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MiniTitle { get; set; }
        public string Description { get; set; }
        public string Essence { get; set; }
        public string Tags { get; set; }
        public double Price { get; set; }
        public long ProductCode { get; set; }
        public List<BoardGameReviewViewModel> Reviews { get; set; }
    }
}
