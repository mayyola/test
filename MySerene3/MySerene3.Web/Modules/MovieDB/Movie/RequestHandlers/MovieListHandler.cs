using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MySerene3.MovieDB.MovieRow>;
using MyRow = MySerene3.MovieDB.MovieRow;

namespace MySerene3.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}