using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityAutomap.Models
{
    public class ProdutoDto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}