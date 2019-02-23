using AutoMapper;
using ClassLibrary1;
using EntityAutomap.Data;
using EntityAutomap.Data.ViewModels;
using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityAutomap.Controllers
{
    public class VendasController : Controller
    {
        Entidades ServiceVendas = new Entidades();
        // GET: Vendas
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descricao")] ProdutoViewModel produto)
        {
            var produtoModel = Mapper.Map<ProdutoViewModel,ProdutoViewDto>(produto);
            ServiceVendas.Create(produtoModel);
            return RedirectToAction("Pedido");
        }
        public ActionResult Pedido()
        {
            PedidoViewModel p = new PedidoViewModel();
            var lista = ServiceVendas.Pedido();
            p.listaProdutos = new SelectList(lista,"Id","Descricao");
            return View(p);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pedido([Bind(Include = "NumeroPedido,Clinte,IdProduto")]PedidoViewModel pedido)
        {
            var pedidoModel = Mapper.Map<PedidoViewModel, PedidoViewDto>(pedido);
            ServiceVendas.PedidoCreate(pedidoModel);
            return RedirectToAction("ListaPedidos");
        }
        public ActionResult ListaPedidos()
        {
            var lista = ServiceVendas.ListaPedidos();
            var listamodel = Mapper.Map<List<ListaPedidoViewDto>, List<ListaPedidoViewModel>>(lista);
            return View(listamodel);
        }
    }
}