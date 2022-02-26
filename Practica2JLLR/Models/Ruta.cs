using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2JLLR.Models
{
    public class Ruta
    {
        [Key]

        public int Id { get; set; }
        public string CodigoMenu { get; set; }
        [ForeignKey("CodigoMenu")]
        public string Nombre { get; set; }
        public virtual Menu Menu { get; set; }

    }
}
