using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class LivrosController : ApiController
    {

        #region "Cadastros de livros"
        Livros[] objLivros = new Livros[]
               {
                        new Livros {    idLivro = 1,
                                        name = "Memórias Póstumas de Brás Cubas",
                                        autor = "Machado de Assis",
                                        Category = "Romance",
                                        Price = 100},

                        new Livros {    idLivro = 2,
                                        name = "Macunaíma",
                                        autor = "Mário de AndradeMachado de Assis",
                                        Category = "Romance",
                                        Price = 150},

                        new Livros {    idLivro = 3,
                                        name = "Calibre 22",
                                        autor = "Rubem Fonseca",
                                        Category = "Suspense",
                                        Price = 150}
               };
        public void inserirLivros(Livros livroNovo)
        {
            try
            {
                Livros[] objLivrosNovo = new Livros[]
                    {
                            new Livros {   idLivro = livroNovo.idLivro,
                                           name = livroNovo.name,
                                           autor = livroNovo.autor,
                                           Category = livroNovo.Category,
                                           Price = livroNovo.Price
                                        }

                    };
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region "Pesquisa de livros por critérios diversos"
        public IEnumerable<Livros> GetAllLivros()
            {
                return objLivros;
            }

            public IHttpActionResult GetProductID(int id)
            {
                var product = objLivros.FirstOrDefault((p) => p.idLivro == id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            public IHttpActionResult GetProductNome(string nome)
            {
                var product = objLivros.FirstOrDefault((p) => p.name == nome);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }

            public IHttpActionResult GetProductAutor(string autor)
            {
                var product = objLivros.FirstOrDefault((p) => p.autor == autor);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }

            public IHttpActionResult GetProductCategoria(string categoria)
            {
                var product = objLivros.FirstOrDefault((p) => p.Category == categoria);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        #endregion

    }
}