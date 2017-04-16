using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Jonas");
        }

        public string Country()
        {
            return "Sweden";
        }

        public string Index()
        {
            return "Hello from Employee";
        }

    }
}
