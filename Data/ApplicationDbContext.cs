using System;
using System.Collections.Generic;
using System.Text;
using Ballerz.Football.Forums.Models;
using Ballerz.Football.Knowledgebase;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ballerz.Football.Data
{ 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
   
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Continents> Continents { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubPerson> ClubPeople { get; set; }
        public DbSet<ClubPersonImages> ClubPersonImages { get; set; }
        public DbSet<ClubPersonHistory> ClubPersonHistory { get; set; }
        public DbSet<ClubRole> ClubRoles { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }        
        public DbSet<StadiumImages> StadiumImages { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Competitions> Competitions { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<CompType> CompType { get; set; }
         public DbSet<YesNo> YesNo { get; set; }
    }
}
