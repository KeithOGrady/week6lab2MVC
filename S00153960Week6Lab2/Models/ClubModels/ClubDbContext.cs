using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rad2016SampleWepApp.Models.ClubModels;

namespace S00153960Week6Lab2.Models.ClubModels
{
    public class ClubDbContext : DbContext
    {
        public DbSet<Club> Clubs  { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ClubEvent> ClubEvent { get; set; }
        public ClubDbContext()
         : base("DefaultConnection")
        { 
        }
    }
    
}