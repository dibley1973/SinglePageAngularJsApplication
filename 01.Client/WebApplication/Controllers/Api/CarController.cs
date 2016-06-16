using System;
using System.IO;
using System.Web.Hosting;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace WebApplication.Controllers.Api
{
    [Route("api/[controller]")]
    public class CarController : ApiController
    {
        const string CarsFileName = @"cars.json";
        private readonly string _fullPath;

        public CarController()
        {
            var appDataPath = HostingEnvironment.MapPath("~/App_Data/");
            _fullPath = string.Concat(appDataPath, @"\", CarsFileName);
        }

        public JToken Get()
        {
            var fileJson = File.ReadAllText(_fullPath);
            var json = JObject.Parse(fileJson);
            return json;
        }

        public JToken Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(string id, JObject car)
        {
            throw new NotImplementedException();
            //var fileJson = File.ReadAllText(_fullPath);
            //var json = JObject.Parse(fileJson);
            //var carData = json.GetValue("carData");


        }
    }
}