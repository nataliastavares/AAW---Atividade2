using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class PedidosController : ApiController
    {
        #region"Realizar Pedidos"
        public void realizarPedidos(Pedidos pedidoNovo)
        {
            try
            {
                Pedidos objPedidoNovo = new Pedidos();
                objPedidoNovo.idPedido = pedidoNovo.idPedido;
                objPedidoNovo.idLivro = pedidoNovo.idLivro;
                objPedidoNovo.status = objPedidoNovo.status;
                objPedidoNovo.dataPedido = objPedidoNovo.dataPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region"Acompanhamento o status das entregas realizadas"
        public Pedidos.StatusPedido consultaStatusPedido(int idPedido)
        {
            try
            {
                Pedidos pedido = new Pedidos();
                pedido = this.buscaPedido(idPedido);
                return pedido.status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Pedidos buscaPedido(int idPedido)
        {
            try
            {

                Pedidos listaPedidos = new Pedidos();
                //Realizaria busca pelo pedido na base de dados
                return listaPedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
