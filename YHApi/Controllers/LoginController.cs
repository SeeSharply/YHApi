using Common;
using Domain.Model;
using Domain.ViewModel;
using Newtonsoft.Json;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace YHApi.Controllers
{
    public class LoginController : BaseController
    {
        // GET api/values
        private IUserManager um;
        public LoginController(IUserManager uManager)
        {
            um = uManager;
        }
        public async Task<IHttpActionResult> Post(UserViewModel user)
        {
            try
            {
                var loginUser = um.DoLogin(user.Name, user.Password);
                if (loginUser == null)
                {
                    return Ok(new BaseResult() { resultType = ResultType.Failed, Message = "用户名密码错误" });
                }
                SessionHelper.SetSession("Login", "success");
                SessionHelper.SetSession("user", loginUser);
                um.SetLoginUserCookie(user);

                return Ok(new BaseResult() { resultType = ResultType.Success, Message = "登陆成功", Data = loginUser });
            }
            catch (Exception e)
            {
                log.Error("登陆失败,发生异常",e);
                return Ok(new BaseResult() { resultType = ResultType.Excption, Message = "登陆出现异常" });
            }
            
        }

    }
}
