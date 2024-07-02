using GrentaStore.Models;

namespace GrentaStore.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenReqModel model);
    }
}
