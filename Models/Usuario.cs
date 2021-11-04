using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Endereço { get; set; }
        [Required]
        public int Cartao { get; set; }
        public bool Status { get; set; }

    }
}
