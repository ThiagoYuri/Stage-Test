﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage.API.DAL.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        /// <summary>
        /// Identificador
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [Required]
        public string Nome { get; set; }


        /// <summary>
        /// Lista de Areas que a empresa tem
        /// </summary>
        ///
        [ForeignKey("PK_Area")]
        public virtual List<Area>? Areas { get; set; }
        public int? PK_Area { get; set; }



        /// <summary>
        /// Lista de todos os processos que a empresa tem
        /// </summary>
        public List<Processo>? Processos { get; set; }


    }
}
