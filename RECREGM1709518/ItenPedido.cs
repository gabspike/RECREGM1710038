using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREGM1709518
{
    public class ItenPedido
    {

        private int quantidade { get; set; }
        private double preco { get; set; }

        public ItenPedido(int quantidade, double preco)
        {
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public int incluirItem()
        {
                var comm = Banco.Abrir();
                comm.CommandText = "insert ItenPedido values('" + quantidade + "', '" + preco + "',)";
                comm.ExecuteNonQuery();
                Banco.Fechar(comm);
        }

        public int excluirItem()
        {

        }

    }
}
