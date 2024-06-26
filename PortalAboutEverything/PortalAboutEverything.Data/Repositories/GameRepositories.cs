﻿using Microsoft.EntityFrameworkCore;
using PortalAboutEverything.Data.Model;
using PortalAboutEverything.Data.Repositories.DataModel;
using PortalAboutEverything.Data.Repositories.RawSql;

namespace PortalAboutEverything.Data.Repositories
{
    public class GameRepositories : BaseRepository<Game>
    {
        public GameRepositories(PortalDbContext db) : base(db) { }

        public List<Game> GetAllWithReviews()
            => _dbSet
            .Include(x => x.Reviews)
            .ToList();

        public List<Game> GetFavoriteGamesByUserId(int userId)
            => _dbSet
            .Where(game => 
                game
                    .UserWhoFavoriteTheGame
                    .Any(u => u.Id == userId))
            .ToList();

        public void Update(Game game)
        {
            var dbGame = Get(game.Id);

            dbGame.Name = game.Name;
            dbGame.Description = game.Description;
            dbGame.YearOfRelease = game.YearOfRelease;

            _dbContext.SaveChanges();
        }

        public IEnumerable<Top3GameDataModel> GetTop3()
        {
            return CustomSqlQuery<Top3GameDataModel>(SqlQueryManager.GetTop3Games)
                .ToList();
        }
    }
}
