using MyRequest = MySerene3.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<MySerene3.Administration.UserRow>;
using MyRow = MySerene3.Administration.UserRow;

namespace MySerene3.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}