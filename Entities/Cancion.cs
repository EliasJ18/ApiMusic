using System.ComponentModel.DataAnnotations;

namespace MusicApi.Entities
{
    public class Cancion
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
    }
}
