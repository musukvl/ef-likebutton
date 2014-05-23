using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using LikeCounter.Data;
using LikeCounter.Data.Model;
using WebApiController = System.Web.Http.ApiController;

namespace LikeCounter.Controllers
{
    public class ApiController : WebApiController
    {
        
        [HttpPost]
        [ActionName("register-like")]
        public async Task<string> RegisterLike([FromBody]string pageId)
        {
            using (var ctx = new LikeCounterContext())
            {
                ctx.LikeRecords.Add(new LikeRecord() {Created = DateTime.UtcNow, PageId = pageId});
                await ctx.SaveChangesAsync();
            }
            return "OK";
        }
    }
}
