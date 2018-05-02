using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    public class Pedido
    {
        public long Id { get; set; }
        public DateTime DataCompra { get; set; }
        public Cliente Cliente { get; set; }
        public List<Lanche> Lanches { get; set; }
        public List<Bebida> Bebidas { get; set; } 

        public Pedido()
        {
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
        }

        public Decimal ValorTotal()
        {
            decimal totalLanches = this.Lanches.Sum(m => m.Valor);
            decimal totalBebidas = this.Bebidas.Sum(m => m.Valor);
            return totalBebidas + totalLanches; 

        }
    }
}
