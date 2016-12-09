using Newtonsoft.Json;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YHApi.Controllers
{
    public class BaseController : ApiController
    {
        public log4net.Ext.IExtLog log = log4net.Ext.ExtLogManager.GetLogger("filelog");
    }
}
