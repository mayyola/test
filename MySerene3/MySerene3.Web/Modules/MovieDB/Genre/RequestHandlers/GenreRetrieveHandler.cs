using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MySerene3.MovieDB.GenreRow>;
using MyRow = MySerene3.MovieDB.GenreRow;

namespace MySerene3.MovieDB;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class GenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreRetrieveHandler
{
    public GenreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}