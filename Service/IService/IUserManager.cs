using Common;
using Domain.Model;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IUserManager:IRepository<Domain.Model.User>
    {
          Task<User>  DoLogin(string userName, string password);
         void SetLoginUserCookie(UserViewModel uvm);
    }
}
