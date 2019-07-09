using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Pedidos
    {
        public enum StatusPedido
        {
            novo, 
            emAndamento,
            concluido,
            AguardandoPagamento,
            PagamentoEfetuado,
            LiberadoParaEntrega,
            EntregaEmAndamento,
            Entregue
        }
        public int idPedido { get; set; }
        public int[] idLivro  { get; set; }
        public int dataPedido { get; set; }
        public StatusPedido status { get; set; }
    }
}