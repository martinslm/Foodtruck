using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    public abstract class Produto
    {

        public long id { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }

        public virtual String Descrever()
        {
            return String.Format($"{this.id} - {this.Nome} - {this.Valor}");
        }
    }
}
