using IdentityManagement.Data;
using IdentityManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.DAL
{
    public static class UserController
    {
        public static int NewUser(ApplicationUser objUser)
        {
            List<ParameterInfo> parameters = new List<ParameterInfo>();
            parameters.Add(new ParameterInfo() { ParameterName = "Id", ParameterValue = objUser.Id });
            parameters.Add(new ParameterInfo() { ParameterName = "UserName", ParameterValue = objUser.UserName });
            parameters.Add(new ParameterInfo() { ParameterName = "Email", ParameterValue = objUser.Email });
            parameters.Add(new ParameterInfo() { ParameterName = "Password", ParameterValue = objUser.Password });
            parameters.Add(new ParameterInfo() { ParameterName = "Status", ParameterValue = objUser.Status });
            int success = SqlHelper.ExecuteQuery("NewUser", parameters);
            return success;
        }

        public static int DeleteUser(ApplicationUser objUser)
        {
            List<ParameterInfo> parameters = new List<ParameterInfo>();
            parameters.Add(new ParameterInfo() { ParameterName = "Id", ParameterValue = objUser.Id });
            int success = SqlHelper.ExecuteQuery("DeleteUser", parameters);
            return success;
        }

        public static ApplicationUser GetUser(string id)
        {
            List<ParameterInfo> parameters = new List<ParameterInfo>();
            parameters.Add(new ParameterInfo() { ParameterName = "Id", ParameterValue = id });
            ApplicationUser oUser = SqlHelper.GetRecord<ApplicationUser>("GetUser", parameters);
            return oUser;
        }

        public static ApplicationUser GetUserByUsername(string userName)
        {
            List<ParameterInfo> parameters = new List<ParameterInfo>();
            parameters.Add(new ParameterInfo() { ParameterName = "Username", ParameterValue = userName });
            ApplicationUser oUser = SqlHelper.GetRecord<ApplicationUser>("GetUserByUsername", parameters);
            return oUser;
        }

        public static int UpdateUser(ApplicationUser objUser)
        {
            List<ParameterInfo> parameters = new List<ParameterInfo>();
            parameters.Add(new ParameterInfo() { ParameterName = "Email", ParameterValue = objUser.Email });
            int success = SqlHelper.ExecuteQuery("UpdateUser", parameters);
            return success;
        }
    }
}