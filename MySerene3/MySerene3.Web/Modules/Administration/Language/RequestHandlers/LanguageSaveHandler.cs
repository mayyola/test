using MyRequest = Serenity.Services.SaveRequest<MySerene3.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MySerene3.Administration.LanguageRow;


namespace MySerene3.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}