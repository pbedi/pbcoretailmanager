using PBRMDesktopUI.Models;
using System.Threading.Tasks;

namespace PBRMDesktopUI.Helper
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}