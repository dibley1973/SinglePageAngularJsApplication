using Newtonsoft.Json.Linq;
using System;
using System.Web.Http;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class CarApiController : ApiController
    {
        public JToken Get()
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath("/");

            throw new NotImplementedException();
        }
    }
}