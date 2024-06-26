﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalAboutEverything.Controllers.ActionFilterAttributes;
using PortalAboutEverything.Data.Enums;
using PortalAboutEverything.Data.Repositories;
using PortalAboutEverything.Services;
using PortalAboutEverything.Models.BoardGame;
using PortalAboutEverything.Mappers;
using PortalAboutEverything.Data.Model;
using PortalAboutEverything.Services.AuthStuff;

namespace PortalAboutEverything.Controllers.ApiControllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    [Authorize]
    public class BoardGameController : Controller
    {
        private readonly PathHelper _pathHelper;
        private readonly BoardGameRepositories _gameRepositories;
        private readonly BoardGameMapper _mapper;
        private readonly AuthService _authServise;

        public BoardGameController(PathHelper pathHelper, BoardGameRepositories gameRepositories, BoardGameMapper mapper, AuthService authServise)
        {
            _pathHelper = pathHelper;
            _gameRepositories = gameRepositories;
            _mapper = mapper;
            _authServise = authServise;
        }

        [HasPermission(Permission.CanDeleteBoardGames)]
        public bool Delete(int id)
        {
            if(!_gameRepositories.Delete(id))
            {
                return false;
            }

            if (_pathHelper.IsBoardGameMainImageExist(id))
            {
                var pathToMainImage = _pathHelper.GetPathToBoardGameMainImage(id);
                System.IO.File.Delete(pathToMainImage);
            }

            if (_pathHelper.IsBoardGameSideImageExist(id))
            {
                var pathToSideImage = _pathHelper.GetPathToBoardGameSideImage(id);
                System.IO.File.Delete(pathToSideImage);
            }

            return true;
        }

        public void AddFavoriteBoardGameForUser(int gameId)
        {
            User user = _authServise.GetUser();
            _gameRepositories.AddUserWhoFavoriteThisBoardGame(user, gameId);
        }

        public void RemoveFavoriteBoardGameForUser(int gameId)
        {
            User user = _authServise.GetUser();
            _gameRepositories.RemoveUserWhoFavoriteThisBoardGame(user, gameId); 
        }

        [AllowAnonymous]
        public List<FavoriteBoardGameIndexViewModel> GetTop3()
        {
            return _gameRepositories
                .GetTop3()
                .Select(_mapper.BuildFavoriteBoardGameIndexViewModel)
                .ToList();
        }
    }
}
