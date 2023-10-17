using Stage.API.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Stage.API.Web.Data.Area;

namespace Stage.API.Web.Data.Processo
{
    public class ReadProcessoDto
    {
        public int Id { get; private set; }       
        public string Nome { get; set; }


    }
}
