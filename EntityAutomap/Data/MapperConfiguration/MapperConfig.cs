using AutoMapper;
using EntityAutomap.Data.ViewModels;
using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityAutomap.Data.MapperConfiguration
{
    public class MapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProdutoViewModel, Produto>();
                cfg.CreateMap<PedidoViewModel, Pedido>()
               .ForMember(dest => dest.Produto,
                m=>m.MapFrom(x=> x.Produto));
                cfg.CreateMap<Pedido, ListaPedidoViewModel>()
                .ForMember(dest => dest.Produto,
                m=>m.MapFrom(x=>x.Produto));
                cfg.CreateMap<ProdutoViewModel, ProdutoViewDto>();
                cfg.CreateMap<PedidoViewModel, PedidoViewDto>()
               .ForMember(dest => dest.Produto,
                m => m.MapFrom(x => x.Produto));
                cfg.CreateMap<PedidoDto, ListaPedidoViewModel>()
                .ForMember(dest => dest.Produto,
                m => m.MapFrom(x => x.Produto));
            });
        }
    }
}