using LanchesMaC.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMaC.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _contexto;

        public CarrinhoCompra(AppDbContext contexto)
        {
            _contexto = contexto;
        }   

        public string CarrinhoCompraId { get; set; }
        
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //define uma sessão acessando o contexto atual(tem que registrar em IServiceContexto
            ISession session = services.GetRequiredService<IHttpContextAcessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //atribui o id do carrinho na Sessão
            session.SetString("CarrinhoId", carrinhoId);

            //retorna o carrinho com o contexto atual e o Id atribuido ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

    }
}
