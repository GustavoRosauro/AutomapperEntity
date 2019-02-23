using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityAutomap.Data.ViewModels
{
    public class ProdutoViewDto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório tanso!")]
        public string Descricao { get; set; }
    }
}