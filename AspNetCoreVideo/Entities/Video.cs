using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }
        //[DataType(DataType.Password)]
        [Required, MinLength(3), MaxLength(80)]
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
