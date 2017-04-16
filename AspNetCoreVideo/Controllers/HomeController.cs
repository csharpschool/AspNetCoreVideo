using AspNetCoreVideo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        public ObjectResult Index()
        {
            var model = new Video { Id = 1, Title = "Shreck" };
            return new ObjectResult(model);
        }
    }
}
