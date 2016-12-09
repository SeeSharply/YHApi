using Common;
using Common.CryptHelper;
using Domain.Model;
using Domain.ViewModel;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceImp
{
    public class UserManager : RepositoryBase<Domain.Model.User>,IUserManager
    {
        public async Task<User> DoLogin(string userName, string password)
        {
            var user =await GetAsync(x=>x.Name==userName);
            if (user != null && MD5Helper.GetMD5Str(password)==user.Password)
            {
                return user;
            }
            return null;
        }
       public void SetLoginUserCookie(UserViewModel uvm,int? id)
        {
            CookieHelper.SetCookie("userName", uvm.Name, 7);
            CookieHelper.SetCookie("userPass", uvm.Password, 7);
           if(id!=null&&id>0)
           {
               CookieHelper.SetCookie("userId",Convert.ToInt32(id).ToString(),7);
           }
        }
    }
}
