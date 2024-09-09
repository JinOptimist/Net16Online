﻿using BoardGamesReviewsApi.Data;
using BoardGamesRiviewsApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesRiviewsApi.Data
{
    public class ReviewsDbContext : DbContext 
    {
        public DbSet<BoardGameReview> BoardGameReviews { get; set; }

        public ReviewsDbContext() { }
        public ReviewsDbContext(DbContextOptions<ReviewsDbContext> contextOptions) : base(contextOptions) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql($"Host={DatabaseSettings.DbHost};Username={DatabaseSettings.DbUsername};Password={DatabaseSettings.DbPassword};Database={DatabaseSettings.DbDbName}");
        }

    }
}
