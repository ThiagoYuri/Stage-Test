using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Processo
{
    public class UpdateProcessoDto
    {
        [Required]
        public string Nome { get; set; }
        [Required, MinLength(14), MaxLength(14)]
        public string CNPJ { get; set; }
    }
}
