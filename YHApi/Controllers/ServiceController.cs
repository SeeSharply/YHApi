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
    public class ServiceController : BaseController
    {
        // GET api/values
        private IProductManager pm;
        public ServiceController(IProductManager pManager)
        {
            pm = pManager;
        }

        public async Task<IHttpActionResult> Get([FromUri]PageRequest p,string searchStr="")
        {
            if(p==null)
            {
                p=new PageRequest()
                {
                    CurrentPage=1,
                    Page=1,
                    PageSize=20
                };
            }
            try
            {
                var query = await pm.LoadAllAsync(x => x.Name.Contains(searchStr));
                p.TotalCount = query.Count(x => x.ID > 0);
                var proList = query.OrderByDescending(x => x.EditTime).Skip(p.PageSize * (p.Page - 1)).Take(p.PageSize).ToList();
                var pageInfo = new PageInfo(p.Page, p.PageSize, p.TotalCount, proList);
                return Ok(new BaseResult() { resultType = ResultType.Success, Message = "查询列表成功", Data = pageInfo });
            }
            catch (Exception e)
            {
                log.Error("获取产品发生异常:", e);
                return Ok(new BaseResult() { resultType = ResultType.Excption, Message = "获取产品发生异常" });
            }
        }

        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                var pro = pm.GetAsync(x => x.ID == id);
                if(pro!=null)
                {
                    return Ok(new BaseResult() {resultType=ResultType.Success,Message="获取产品成功",Data=pro });
                }
                else
                {
                    return Ok(new BaseResult() { resultType = ResultType.Failed, Message = "未找到对应产品" });
                }
            }
            catch (Exception e)
            {
                log.Error("获取产品发生异常:id="+id,e);
                return Ok(new BaseResult() { resultType = ResultType.Excption, Message = "获取产品发生异常" });
            }
        }
        
        public async Task<IHttpActionResult> Post()
        {
            return Ok();
        }
        public async Task<IHttpActionResult> Put()
        {
            return Ok();
        }

    }
}
