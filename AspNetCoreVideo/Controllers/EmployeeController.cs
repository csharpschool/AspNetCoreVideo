using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("[controller]")]
    public class EmployeeController
    {
        [Route("[action]")]
        public string Name()
        {
            return "Jonas";
        }

        [Route("[action]")]
        public string Country()
        {
            return "Sweden";
        }

        [Route("[action]")]
        public string Index()
        {
            return "Hello from Employee";
        }

    }
}
