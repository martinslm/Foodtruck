using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foodtruck.Negocio.Persistencia
{
    public class Banco : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Bebida> Bebidas { get; set; }
        public virtual DbSet<Lanche> Lanches { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }

    }
}
