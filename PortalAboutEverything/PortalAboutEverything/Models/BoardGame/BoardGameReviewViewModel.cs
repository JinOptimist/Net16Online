﻿namespace PortalAboutEverything.Models.BoardGame
{
    public class BoardGameReviewViewModel
    {
        public int BoardGameId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfCreationInStringFormat { get; set; }
        public string Text { get; set; }
    }
}
