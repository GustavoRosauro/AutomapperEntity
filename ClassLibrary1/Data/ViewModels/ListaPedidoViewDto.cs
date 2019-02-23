using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityAutomap.Data.ViewModels
{
    public class ListaPedidoViewDto
    {
        public int Id { get; set; }
        [Display(Name = "Numero do Pedido")]
        public string NumeroPedido { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string Clinte { get; set; }
        [Display(Name = "Selecione o Produto")]
        public int? IdProduto { get; set; }
        [Display(Name = "Descrição")]
        public virtual ProdutoDto Produto { get; set; }
    }
}