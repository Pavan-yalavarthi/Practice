using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MovieCodeFirst.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("name=connectstr") { }
        public DbSet<Movie> Movies { get; set; }
    }
}
