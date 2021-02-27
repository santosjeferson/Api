using easyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_teste.Controllers
{
    public class ProdutosController : ApiController
    {
        private static List<Produtos> produtos = new List<Produtos>();

        public List<Produtos> Get()
        {
            return produtos;
        }

        public void Post(string nome)
        {   
            if(!string.IsNullOrEmpty(nome))
                produtos.Add(new Produtos(nome));
        }

        public void Delete(string nome)
        {
            produtos.RemoveAt(produtos.IndexOf(produtos.First(x => x.Produto.Equals(nome))));
        }

        public void Put(string nome, string new_value)
        {
           
        produtos.RemoveAt(produtos.IndexOf(produtos.First(x => x.Produto.Equals(nome))));
        produtos.Add(new Produtos(new_value));  

        }
    }
}   
