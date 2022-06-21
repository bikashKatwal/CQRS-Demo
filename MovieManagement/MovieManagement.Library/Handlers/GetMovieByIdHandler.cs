
using MediatR;
using MovieManagement.Library.Data;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;

namespace MovieManagement.Library.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieModel>
    {
        private readonly IDataRepository<MovieModel> _dataRepository;
        public GetMovieByIdHandler(IDataRepository<MovieModel> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public Task<MovieModel> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetById(request.id));
        }
    }
}
