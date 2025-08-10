using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Moto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Valor { get; set; }

        public Moto()
        {
            
        }

    }
}