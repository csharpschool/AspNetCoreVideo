using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
            var model = _videos.GetAll().Select(video => new VideoViewModel
            {
                Id = video.Id,
                Title = video.Title,
                Genre = Enum.GetName(typeof(Genres), video.GenreId)
            });

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);
            return new ObjectResult(model);
        }

    }
}
