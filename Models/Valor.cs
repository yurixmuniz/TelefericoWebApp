using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Valor
    {
        public int ValorId { get; set; }
        [Required]
        public int FornecedorId { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}
