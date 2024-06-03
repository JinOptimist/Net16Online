﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalAboutEverything.Data;

#nullable disable

namespace PortalAboutEverything.Data.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20240531190042_LinkBetweenMoviesAndUser")]
    partial class LinkBetweenMoviesAndUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoardGameUser", b =>
                {
                    b.Property<int>("FavoriteBoardsGamesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersWhoFavoriteThisBoardGameId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteBoardsGamesId", "UsersWhoFavoriteThisBoardGameId");

                    b.HasIndex("UsersWhoFavoriteThisBoardGameId");

                    b.ToTable("BoardGameUser");
                });

            modelBuilder.Entity("GameStoreUser", b =>
                {
                    b.Property<int>("MyGamesId")
                        .HasColumnType("int");

                    b.Property<int>("UserTheGameId")
                        .HasColumnType("int");

                    b.HasKey("MyGamesId", "UserTheGameId");

                    b.HasIndex("UserTheGameId");

                    b.ToTable("GameStoreUser");
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.Property<int>("FavoriteGamesId")
                        .HasColumnType("int");

                    b.Property<int>("UserWhoFavoriteTheGameId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteGamesId", "UserWhoFavoriteTheGameId");

                    b.HasIndex("UserWhoFavoriteTheGameId");

                    b.ToTable("GameUser");
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.Property<int>("FavoriteMoviesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersWhoFavoriteTheMovieId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteMoviesId", "UsersWhoFavoriteTheMovieId");

                    b.HasIndex("UsersWhoFavoriteTheMovieId");

                    b.ToTable("MovieUser");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BoardGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Essence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiniTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<long>("ProductCode")
                        .HasColumnType("bigint");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoardGames");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BoardGameReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoardGameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoardGameId");

                    b.HasIndex("GameId");

                    b.ToTable("BoardGameReviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BookClub.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummaryOfBook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfPublication")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BookClub.BookReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookIllustrationsRating")
                        .HasColumnType("int");

                    b.Property<int>("BookPrintRating")
                        .HasColumnType("int");

                    b.Property<int>("BookRating")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelingId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.GameStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GameStores");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfEvent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistoryEvents");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.MovieReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieReviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Now")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Store.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Traveling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeOfCreation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Travelings");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.VideoLibrary.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.VideoLibrary.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FolderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("BoardGameUser", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.BoardGame", null)
                        .WithMany()
                        .HasForeignKey("FavoriteBoardsGamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalAboutEverything.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersWhoFavoriteThisBoardGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameStoreUser", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.GameStore", null)
                        .WithMany()
                        .HasForeignKey("MyGamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalAboutEverything.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserTheGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.Game", null)
                        .WithMany()
                        .HasForeignKey("FavoriteGamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalAboutEverything.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserWhoFavoriteTheGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.Movie", null)
                        .WithMany()
                        .HasForeignKey("FavoriteMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalAboutEverything.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersWhoFavoriteTheMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BoardGameReview", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.BoardGame", "BoardGame")
                        .WithMany("Reviews")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalAboutEverything.Data.Model.Game", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("BoardGame");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BookClub.BookReview", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.BookClub.Book", "Book")
                        .WithMany("BookReviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Book");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Comment", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.Traveling", "Traveling")
                        .WithMany("Comments")
                        .HasForeignKey("TravelingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Traveling");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.MovieReview", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Traveling", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.User", "User")
                        .WithMany("Travelings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.VideoLibrary.Video", b =>
                {
                    b.HasOne("PortalAboutEverything.Data.Model.VideoLibrary.Folder", "Folder")
                        .WithMany("Videos")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BoardGame", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.BookClub.Book", b =>
                {
                    b.Navigation("BookReviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Game", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Movie", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.Traveling", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.User", b =>
                {
                    b.Navigation("Travelings");
                });

            modelBuilder.Entity("PortalAboutEverything.Data.Model.VideoLibrary.Folder", b =>
                {
                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}