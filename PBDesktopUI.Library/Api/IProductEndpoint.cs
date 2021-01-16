using PBDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PBDesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}