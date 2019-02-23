using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityAutomap.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public string NumeroPedido { get; set; }
        public string Clinte { get; set; }
        public int? IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
}