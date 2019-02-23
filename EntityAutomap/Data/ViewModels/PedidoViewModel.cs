using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityAutomap.Data.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Numero do Pedido")]
        [Required]
        public string NumeroPedido { get; set; }
        [Display(Name = "Nome do Cliente")]
        [Required]
        public string Clinte { get; set; }
        [Display(Name = "Selecione o Produto")]
        [Required]
        public int? IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public SelectList listaProdutos { get; set; }
    }
}