using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2JLLR.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string CodigoMenu { get; set; }
    }
}
