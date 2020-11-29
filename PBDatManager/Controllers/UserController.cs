using Microsoft.AspNet.Identity;
using PBDataManager.Library.DataAccess;
using PBDataManager.Library.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PBDatManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            
            return data.GetUserById(userId).First();
        }

        
    }
}
