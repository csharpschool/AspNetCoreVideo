using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("employee")]
    public class EmployeeController
    {
        [Route("name")]
        public string Name()
        {
            return "Jonas";
        }

        [Route("country")]
        public string Country()
        {
            return "Sweden";
        }

        [Route("")]
        public string Index()
        {
            return "Hello from Employee";
        }

    }
}
