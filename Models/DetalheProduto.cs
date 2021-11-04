using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class DetalheProduto
    {
        public int DetalheProdutoId { get; set; }
        public int ProdutoId { get; set; }
        public double Valor { get; set; }
        public DateTime DtRegistro { get; set; }
    }
}
