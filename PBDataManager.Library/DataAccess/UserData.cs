using PBDataManager.Library.Inernal.DataAccess;
using PBDataManager.Library.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string UserId)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Id = UserId };
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "PBRMData");
            return output;
        }
    }
}
