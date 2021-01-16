using PBDesktopUI.Library.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace PBDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
        HttpClient ApiClient { get; }
    }
}