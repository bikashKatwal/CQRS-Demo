

using MediatR;
using MovieManagement.Library.Commands;
using MovieManagement.Library.Data;
using MovieManagement.Library.Models;

namespace MovieManagement.Library.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, MovieModel>
    {
        private readonly IDataRepository<MovieModel> _dataRepository;

        public AddMovieHandler(IDataRepository<MovieModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddMovie(request.Movie));
        }
    }
}
