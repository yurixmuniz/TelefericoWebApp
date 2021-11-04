using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefericoWebApp.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int UsuarioId { get; set; }
        public double Valor { get; set; }
        public DateTime DtPedido { get; set; }

    }
}
