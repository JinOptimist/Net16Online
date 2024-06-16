﻿using Microsoft.EntityFrameworkCore;
using PortalAboutEverything.Data.Model;
using PortalAboutEverything.Data.Repositories.DataModel;
using PortalAboutEverything.Data.Repositories.RawSql;

namespace PortalAboutEverything.Data.Repositories
{
    public class BoardGameRepositories : BaseRepository<BoardGame>
    {
        public BoardGameRepositories(PortalDbContext dbContext) : base(dbContext) { }

        public BoardGame GetWithReviews(int id)
            => _dbSet
            .Include(boardGame => boardGame.Reviews)
            .Single(boardGame => boardGame.Id == id);

        public BoardGame GetWithUsersWhoFavoriteThisBoardGame(int id)
            => _dbSet
            .Include(boardGame => boardGame.UsersWhoFavoriteThisBoardGame)
            .Single(boardGame => boardGame.Id == id);

        public List<BoardGame> GetFavoriteBoardGamesForUser(int userId)
            => _dbSet
            .Where(boardGame => boardGame.UsersWhoFavoriteThisBoardGame.Any(user =>  user.Id == userId))
            .ToList();

        public void Update(BoardGame boardGame)
        {
            BoardGame updatedboardGame = Get(boardGame.Id);
            updatedboardGame.Title = boardGame.Title;
            updatedboardGame.MiniTitle = boardGame.MiniTitle;
            updatedboardGame.Description = boardGame.Description;
            updatedboardGame.Essence = boardGame.Essence;
            updatedboardGame.Tags = boardGame.Tags;
            updatedboardGame.Price = boardGame.Price;
            updatedboardGame.ProductCode = boardGame.ProductCode;

            _dbContext.SaveChanges();
        }

        public void AddUserWhoFavoriteThisBoardGame(User user, int gameId)
        {
            BoardGame boardGame = GetWithUsersWhoFavoriteThisBoardGame(gameId);
            boardGame.UsersWhoFavoriteThisBoardGame.Add(user);

            _dbContext.SaveChanges();
        }

        public void RemoveUserWhoFavoriteThisBoardGame(User user, int gameId)
        {
            BoardGame boardGame = GetWithUsersWhoFavoriteThisBoardGame(gameId);
            boardGame.UsersWhoFavoriteThisBoardGame.Remove(user);

            _dbContext.SaveChanges();
        }

        public IEnumerable<Top3BoardGameDataModel> GetTop3()
        {
            return CustomSqlQuery<Top3BoardGameDataModel>(SqlQueryManager.GetTop3BoardGames)
                .ToList();
        }
    }
}
