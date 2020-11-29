using PBRMDesktopUI.Models;
using System.Threading.Tasks;

namespace PBDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}