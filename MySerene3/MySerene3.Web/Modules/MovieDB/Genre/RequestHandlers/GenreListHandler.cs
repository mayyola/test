using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MySerene3.MovieDB.GenreRow>;
using MyRow = MySerene3.MovieDB.GenreRow;

namespace MySerene3.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}