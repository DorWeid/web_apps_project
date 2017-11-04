using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ex2.Models;

namespace Ex2.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("ProjectContext") { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Comment> Comments {get; set;}
        public DbSet<Map> Maps {get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}