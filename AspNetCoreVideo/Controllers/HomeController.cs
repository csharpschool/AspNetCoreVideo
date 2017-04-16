using AspNetCoreVideo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll();

            return View(model);
        }
    }
}
