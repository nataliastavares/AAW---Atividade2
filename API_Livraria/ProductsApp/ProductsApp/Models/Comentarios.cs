using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Comentarios
    {
        public int idComentario { get; set; }
        public int idLivro { get; set; }
        public int texto { get; set; }
        public int dataComentario { get; set; }
    }
}