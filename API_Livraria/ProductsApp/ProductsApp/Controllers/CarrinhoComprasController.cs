using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class CarrinhoComprasController : ApiController
    {
        private List<Livros> carrinhoCompras = new List<Livros>();

        #region"Manipular um carrinho de compras"
            public void insereLivroCarrinhoCompras(Livros livro)
            {
                carrinhoCompras.Add(livro);
            }
            public void removeLivroCarrinhoCompras(Livros livro)
            {
                carrinhoCompras.Remove(livro);
            }
        #endregion
    }
}
