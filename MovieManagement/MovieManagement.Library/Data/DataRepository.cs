using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public class DataRepository : IDataRepository<MovieModel>
    {
        private static List<MovieModel> _movies = new()
        {
            new MovieModel{ Id=1, Name="Test Movie 1", Cost=1000},
            new MovieModel{ Id=2, Name="Test Movie 2", Cost=2000},
        };
        public MovieModel AddMovie(MovieModel movie)
        {
           _movies.Add(movie);
            return movie;
        }

        public MovieModel GetById(int id) => _movies.FirstOrDefault(m => m.Id == id);

        public List<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
