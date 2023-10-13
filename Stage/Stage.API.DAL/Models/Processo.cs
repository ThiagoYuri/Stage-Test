using Stage.API.DAL.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage.API.DAL.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public TipoProcesso TipoProcesso { get; set; }

        public Processo? ProcessoPai { get; set; }
        public List<Processo>? SubProcessos { get; set; }

    }
}
