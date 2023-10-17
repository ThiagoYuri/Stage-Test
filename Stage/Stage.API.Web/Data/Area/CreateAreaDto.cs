using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Area
{
    public class CreateAreaDto
    {
        [Required]
        public string Nome { get; set; }
    }

}
