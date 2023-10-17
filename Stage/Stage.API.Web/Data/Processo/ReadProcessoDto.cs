using Stage.API.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Stage.API.Web.Data.Area;
using Stage.API.DAL.Models.Enum;

namespace Stage.API.Web.Data.Processo
{
    public class ReadProcessoDto
    {
        public int Id { get; private set; }       
        public string Nome { get; set; }

        public int Ordem { get; set; }


        public DAL.Models.Processo ProcessoPai { get; set; }
        public DAL.Models.Area Area { get; set; }

        public List<DAL.Models.Processo> SubProcessos { get; set; }

    }
}
