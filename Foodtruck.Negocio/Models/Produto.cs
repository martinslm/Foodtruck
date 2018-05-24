using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    //[Table(name: "Produtos")]
    public abstract class Produto
    {

        public long Id { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public virtual String Descrever()
        {
            return String.Format($"{this.Id} - {this.Nome} - {this.Valor}");
        }
    }
}
