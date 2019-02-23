using EntityAutomap.Models;
using System.ComponentModel.DataAnnotations;

namespace EntityAutomap.Data.ViewModels
{
    public class PedidoViewDto
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
        public virtual ProdutoDto Produto { get; set; }
    }
}