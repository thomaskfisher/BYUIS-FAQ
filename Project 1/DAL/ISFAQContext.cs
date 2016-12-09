using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1.Models;
using System.Data.Entity;

//THESE DBSET'S ARE CREATED FOR ALL 4 MODELS

namespace Project_1.DAL
{
    public class ISFAQContext : DbContext
    {
        public ISFAQContext() : base("ISFAQContext")
        {

        }

        public DbSet<DegreeQuestions> Degree_Question { get; set; }
        public DbSet<Degrees> Degree { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<DegreesAndQuestions> DegreeAndQuestion { get; set; }
    }
}