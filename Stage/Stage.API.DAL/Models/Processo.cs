using Stage.API.DAL.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage.API.DAL.Models
{
    [Table("Processo")]
    public class Processo
    {
        /// <summary>
        /// Identificador
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [Required]
        public string Nome { get; set; }


        /// <summary>
        /// Tipo de processo Sistemica,Manual,AuxilioExterno
        /// </summary>
        [Required]
        public TipoProcesso TipoProcesso { get; set; }

        /// <summary>
        /// Caso tenha o processo e conciderado um Sub-processo, caso não tenha o processo e conciderado Processo-Pai
        /// </summary>
        ///  
        [ForeignKey("PK_ProcessoPai")]
        public virtual Processo? ProcessoPai { get; set; }
        public int? PK_ProcessoPai { get; set; }

        public int Ordem { get; set; }

        public virtual List<Processo?> SubProcessos { get; set; }


        /// <summary>
        /// Area que o processo está relacionada
        /// </summary>

        [Required,ForeignKey("PK_Area")]
        public virtual Area? Area { get; set;}
        public int PK_Area { get; set; }



    }
}
