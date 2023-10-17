using Stage.API.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Empresa
{
    public class ReadEmpresaDto
    {
        public int Id { get; private set; }       
        public string Nome { get; set; }
        public string CNPJ { get; set; }        
    }
}
