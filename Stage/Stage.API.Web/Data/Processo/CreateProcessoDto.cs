using Stage.API.DAL.Models;
using Stage.API.DAL.Models.Enum;
using Stage.API.Web.Data.Area;
using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Processo
{
    public class CreateProcessoDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public TipoProcesso TipoProcesso { get; set; }

        public int Ordem { get; set; }

        public int? PK_ProcessoPai { get; set; }

        [Required]
        public int PK_Area { get; set; }


    }

}
