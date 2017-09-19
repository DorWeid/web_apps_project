using Ex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex2.DAL
{
    public class ProjectInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var posts = new List<Post>
            {
                new Post {
                    PostID = 1,
                    Title = "How it's being main widow/hanzo",
                    AuthorName = "Matan",
                    AuthorSiteURL="http://www.overwatch.com",
                    Date=new DateTime(1996, 4, 20),
                    Content="Not very simple, you get alot of complaints in every game start. but yolo",
                    ImageURL="https://i.ytimg.com/vi/P7KKbxN8dVY/maxresdefault.jpg",
                    VideoURL="https://www.youtube.com/watch?v=s4DRQLkRGR4",
                },
                new Post  {
                    PostID = 2,
                    Title = "The feeling being carried by the main widow",
                    AuthorName="Avner",
                    AuthorSiteURL="http://losers.com",
                    Date=new DateTime(1995,1,1),
                    Content="I owe my rank to the main widow, he's such a pro and im such a noob player",
                    ImageURL="https://i.ytimg.com/vi/xAXVTUkwJRc/maxresdefault.jpg",
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

            var fans = new List<Fan>
            {
                new Fan {
                    FanId=1,
                    FirstName="First",
                    LastName="LastFirst",
                    UserGender=Gender.Male,
                    BirthDate=new DateTime(1990, 5, 10),
                    Vetek=2
                },
                new Fan {
                    FanId=2,
                    FirstName="Second",
                    LastName="LastSecond",
                    UserGender=Gender.Female,
                    BirthDate=new DateTime(1990, 2, 3),
                    Vetek=2
                }
            };

            fans.ForEach(f => context.Fans.Add(f));
            context.SaveChanges();
        }
    }
}