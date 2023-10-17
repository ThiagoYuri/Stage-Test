using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Area
{
    public class UpdateAreaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required, MinLength(14), MaxLength(14)]
        public string CNPJ { get; set; }
    }
}
