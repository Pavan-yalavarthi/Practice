using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCodeFirst.Models;

namespace MovieCodeFirst.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Save();
    }
}
