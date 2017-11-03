using Ex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex2.DAL
{
    public class ProjectInitializer : System.Data.Entity.DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var heroes = new List<Hero>
            {
                new Hero
                {
                    HeroID=1,
                    Name="Tracer",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=200,
                },
                new Hero
                {
                    HeroID=2,
                    Name="Soldier",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=250,
                },
                new Hero
                {
                    HeroID=3,
                    Name="Zenyata",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Support,
                    HP=200,
                },
                new Hero
                {
                    HeroID=4,
                    Name="Reinhart",
                    AttackStyle=AttackStyle.Melee,
                    HeroRole=Role.Tank,
                    HP=500,
                },
            };
            heroes.ForEach(h => context.Heroes.Add(h));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post {
                    PostID = 1,
                    Title = "I want to play with u",
                    AuthorName = "Matan",
                    Date=new DateTime(1996, 4, 20),
                    Content="I like gaming",
                    HeroID=heroes[0].HeroID,
                },
                new Post  {
                    PostID = 2,
                    Title = "The feeling being carried by the main widow",
                    AuthorName="Avner",
                    Date=new DateTime(1995,1,1),
                    Content="I owe my rank to the main widow, he's such a pro and im such a noob player",
                    HeroID=heroes[1].HeroID,
                }
            };

            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment
                {
                    CommentID=1,
                    PostID=1,
                    Title="Such a good widow",
                    AuthorName="main noob",
                    AuthorSiteURL="http://www.google.com",
                    Content="Plz play with me",
                },
                new Comment
                {
                    CommentID=2,
                    PostID=2,
                    Title="Such a noob.",
                    AuthorName="hanzo",
                    AuthorSiteURL="http://www.youtube.com",
                    Content="kys",
                },
            };
            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();

            var maps = new List<Map>
            {
                new Map
                {
                    MapID=1,
                    Name="Temple of Anubis",
                    Address="Ein gedi petah tiqva 12",

                },
            };
            maps.ForEach(m => context.Maps.Add(m));
            context.SaveChanges();

        }
    }
}