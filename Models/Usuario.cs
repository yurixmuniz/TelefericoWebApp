using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereço { get; set; }
        public decimal Cartao { get; set; }
        public bool Status { get; set; }

    }
}
