using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace easyAPI.Models
{

    public class Produtos
    {
        public string Produto { get; set; }

        public Produtos(string get_dados)
        {
            this.Produto = get_dados;
        }


    }
}