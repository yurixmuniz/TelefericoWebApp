using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public string Fornecedor { get; set; }
    }
}
