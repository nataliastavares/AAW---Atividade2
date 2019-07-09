using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ComentariosController : ApiController
    {
        #region"Postar comentários para livros.(resenhadas)"
        public void inserirComentarios(Comentarios comentario)
        {
            try
            {
                Comentarios[] resenha = new Comentarios[]
                    {
                                new Comentarios {   idComentario = comentario.idComentario,
                                                    idLivro = comentario.idLivro,
                                                    dataComentario = comentario.dataComentario,
                                                    texto = comentario.texto
                                                }

                    };
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
    }
}
