using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Empresa
{
    public class CreateAreaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required, MinLength(14), MaxLength(14)]
        public string CNPJ { get; set; }
    }

}
