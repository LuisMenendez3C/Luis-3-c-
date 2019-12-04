using System;
using System.Collections.Generic;
using System.Text;

namespace InstalacionyVentaDeCamarasDeSeguridad
{
    class HistorialDePedidos
    {
        public HistorialDePedidos()
        {

        }
        public DateTime Fechadepedidohecho { get; set; }
        public string Detalledelpedido { get; set; }//pedido pendiente
        public DateTime Fechadellegadadelpedido{ get; set; }
    }
}
