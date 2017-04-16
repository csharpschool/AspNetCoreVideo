using AspNetCoreVideo.Models;
using System.Collections.Generic;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
