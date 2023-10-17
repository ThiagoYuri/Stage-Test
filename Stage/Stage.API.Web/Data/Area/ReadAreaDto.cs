using Stage.API.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stage.API.Web.Data.Area
{
    public class ReadAreaDto
    {
        public int Id { get; private set; }       
        public string Nome { get; set; }    
    }
}
