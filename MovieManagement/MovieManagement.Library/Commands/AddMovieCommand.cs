using MediatR;
using MovieManagement.Library.Models;

namespace MovieManagement.Library.Commands
{
    public record AddMovieCommand(MovieModel Movie):IRequest<MovieModel>;
   
}
