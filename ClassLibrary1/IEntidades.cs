using EntityAutomap.Data.ViewModels;
using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IEntidades
    {
        void Create(ProdutoViewDto produto);
        List<ProdutoDto> Pedido();
        void PedidoCreate(PedidoViewDto pedido);
        List<ListaPedidoViewDto> ListaPedidos();
    }
}
