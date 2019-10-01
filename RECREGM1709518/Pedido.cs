using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1709518
{
    public class Pedido
    {

        private DateTime dataPedido { get; set; }
        private string vendedor { get; set; }
        private Boolean status { get; set; }
        private string observacoes { get; set; }
        private string codigo { get; set;  }

        public Pedido(DateTime dataPedido, string vendedor, bool status, string observacoes, string codigo)
        {
            this.dataPedido = dataPedido;
            this.vendedor = vendedor;
            this.status = status;
            this.observacoes = observacoes;
            this.codigo = codigo;
        }

        public void encerrarPedido()
        {

        }

        public void cancelarPedido()
        {

        }

        public void criarPedido()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "insert pedido values('" + codigo + "','" + dataPedido + "','" + vendedor + "','" + status + "','" + observacoes + "',)";
            comm.ExecuteNonQuery();
            Banco.Fechar(comm);
        }
    }
}
