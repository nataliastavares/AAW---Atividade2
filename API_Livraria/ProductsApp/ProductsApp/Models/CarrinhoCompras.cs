using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class CarrinhoCompras
    {
        public int idUsuario { get; set; }
        public int[] idLivro { get; set; }
    }
}
