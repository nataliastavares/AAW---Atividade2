﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Livros
    {
        public int idLivro { get; set; }
        public string name { get; set; }
        public string autor { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}