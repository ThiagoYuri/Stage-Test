using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stage.API.DAL.Models
{
    [Table("Area")]
    public class Area
    {
        /// <summary>
        /// Identificador
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        /// <summary>
        /// Nome da area
        /// </summary>
        [Required]
        public string Nome { get; set; }
        /// <summary>
        /// Empresas 
        /// </summary>
        /// 
        [ForeignKey("PK_Empresa")]
        public virtual List<Empresa>? Empresa { get; set; }
        public int? PK_Empresa { get; set; }


    }
}