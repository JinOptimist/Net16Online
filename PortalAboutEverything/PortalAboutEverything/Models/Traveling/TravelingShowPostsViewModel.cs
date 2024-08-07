﻿namespace PortalAboutEverything.Models.Traveling
{
    public class TravelingShowPostsViewModel
    {
        public List<TravelingPostsViewModel> TravelingPostsViewModels { get; set; }
        public TopTravelingByCommentsViewModel TopTravelingByCommentsViewModel { get; set; }
        public bool IsTravingAdmin { get; set; }
        public string LastNews { get; set; }
        public string? RandomJoke { get; set; }
    }
}
