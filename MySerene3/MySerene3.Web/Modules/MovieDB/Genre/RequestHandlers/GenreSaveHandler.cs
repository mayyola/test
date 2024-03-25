using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MySerene3.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MySerene3.MovieDB.GenreRow;

namespace MySerene3.MovieDB;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}