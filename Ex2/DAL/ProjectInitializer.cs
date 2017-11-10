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
                    Name="Doomfist",
                    AttackStyle=AttackStyle.Melee,
                    HeroRole=Role.Attack,
                    HP=250,
                },
                new Hero
                {
                    HeroID=2,
                    Name="Genji",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=200,
                },
                new Hero
                {
                    HeroID=3,
                    Name="McCree",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=200,
                },
                new Hero
                {
                    HeroID=4,
                    Name="Pharah",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=200,
                },
                new Hero
                {
                    HeroID=5,
                    Name="Reaper",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=250,
                },
                new Hero
                {
                    HeroID=6,
                    Name="Soldier",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=250,
                },
                new Hero
                {
                    HeroID=7,
                    Name="Sombra",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=200,
                },
                new Hero
                {
                    HeroID=8,
                    Name="Tracer",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Attack,
                    HP=150,
                },
                new Hero
                {
                    HeroID=9,
                    Name="Bastion",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=300,
                },
                new Hero
                {
                    HeroID=10,
                    Name="Hanzo",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=200,
                },
                new Hero
                {
                    HeroID=11,
                    Name="Junkrat",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=200,
                },
                new Hero
                {
                    HeroID=12,
                    Name="Mei",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=250,
                },
                new Hero
                {
                    HeroID=13,
                    Name="Torbjorn",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=200,
                },
                new Hero
                {
                    HeroID=14,
                    Name="Widowmaker",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Defender,
                    HP=200,
                },
                new Hero
                {
                    HeroID=15,
                    Name="D.Va",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Tank,
                    HP=600,
                },
                new Hero
                {
                    HeroID=16,
                    Name="Orisa",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Tank,
                    HP=400,
                },
                new Hero
                {
                    HeroID=17,
                    Name="Reinhart",
                    AttackStyle=AttackStyle.Melee,
                    HeroRole=Role.Tank,
                    HP=500,
                },
                new Hero
                {
                    HeroID=18,
                    Name="Roadhog",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Tank,
                    HP=600,
                },
                new Hero
                {
                    HeroID=19,
                    Name="Winston",
                    AttackStyle=AttackStyle.Melee,
                    HeroRole=Role.Tank,
                    HP=500,
                },
                new Hero
                {
                    HeroID=20,
                    Name="Zarya",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Tank,
                    HP=400,
                },
                new Hero
                {
                    HeroID=21,
                    Name="Ana",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Support,
                    HP=200,
                },
                new Hero
                {
                    HeroID=22,
                    Name="Lucio",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Support,
                    HP=200,
                },
                new Hero
                {
                    HeroID=23,
                    Name="Mercy",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Support,
                    HP=200,
                },
                new Hero
                {
                    HeroID=24,
                    Name="Symmetra",
                    AttackStyle=AttackStyle.Melee,
                    HeroRole=Role.Support,
                    HP=200,
                },
                new Hero
                {
                    HeroID=25,
                    Name="Zenyata",
                    AttackStyle=AttackStyle.Range,
                    HeroRole=Role.Support,
                    HP=200,
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
                },
                new Post  {
                    PostID = 3,
                    Title = "IDK What im talking about",
                    AuthorName="Adir",
                    Date=new DateTime(1999,2,3),
                    Content="I cant play this game becaue Genji is op",
                    HeroID=heroes[1].HeroID,
                },
                new Post  {
                    PostID = 4,
                    Title = "Who is Doomfist",
                    AuthorName="No one",
                    Date=new DateTime(1999,2,3),
                    Content="never heard of him",
                    HeroID=heroes[0].HeroID,
                },
                new Post  {
                    PostID = 3,
                    Title = "Tracer should be more fun",
                    AuthorName="Dor",
                    Date=new DateTime(1999,2,3),
                    Content="but she's not",
                    HeroID=heroes[8].HeroID,
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
                    Address="Giza Plateau",

                },
                new Map
                {
                    MapID=2,
                    Name="Hanamura",
                    Address="Tokyo, Japan",

                },
                new Map
                {
                    MapID=3,
                    Name="Volskaya Industries",
                    Address="St. Petersburg, Russia",

                },
                new Map
                {
                    MapID=4,
                    Name="Dorado",
                    Address="Veracruz, Mexico",

                },
                new Map
                {
                    MapID=5,
                    Name="Junkertown",
                    Address="Northern Territory, Australia",

                },
                new Map
                {
                    MapID=6,
                    Name="Lijiang Tower",
                    Address="China",

                },
                new Map
                {
                    MapID=7,
                    Name="Eichenwalde",
                    Address="Stuttgart, Germany",

                },
                new Map
                {
                    MapID=8,
                    Name="Hollywood",
                    Address="Los Angeles, California",

                },
                new Map
                {
                    MapID=9,
                    Name="King's row",
                    Address="London, England",

                },
            };
            maps.ForEach(m => context.Maps.Add(m));
            context.SaveChanges();

        }
    }
}