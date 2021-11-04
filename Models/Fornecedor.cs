using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
