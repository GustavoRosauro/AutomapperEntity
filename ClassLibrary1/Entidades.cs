using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EntityAutomap.Data;
using EntityAutomap.Data.ViewModels;
using EntityAutomap.Models;

namespace ClassLibrary1
{
    public class Entidades : IEntidades
    {
        VendasContext vendas = new VendasContext();
        public void Create(ProdutoViewDto produto)
        {
            var produtoModel = Mapper.Map<ProdutoViewDto, ProdutoDto>(produto);
            vendas.Produtos.Add(produtoModel);
            vendas.SaveChanges();
        }

        public List<ListaPedidoViewDto> ListaPedidos()
        {
            var lista = vendas.Pedidos.ToList();
            var listaPedidosView = Mapper.Map<List<PedidoDto>, List<ListaPedidoViewDto>>(lista);
            return listaPedidosView;
        }

        public List<ProdutoDto> Pedido()
        {
            var lista = vendas.Produtos.ToList();
            return lista;
        }

        public void PedidoCreate(PedidoViewDto pedido)
        {
            var pedidoModel = Mapper.Map<PedidoViewDto, PedidoDto>(pedido);
            vendas.Pedidos.Add(pedidoModel);
            vendas.SaveChanges();
        }
    }
}
