using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoNET002.Models
{
    public class Peliculas
    {
        [Key]
        public int ID { get; set; }

        public string Director { get; set; }
        public string Name { get; set; }
    }
}
