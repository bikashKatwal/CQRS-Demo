using MediatR;
using MovieManagement.Library.Data;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;

namespace MovieManagement.Library.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository<MovieModel> _dataRepository;

        public GetMovieListHandler(IDataRepository<MovieModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetMovies());
        }
    }
}
