using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ped_Hospitalar.Modelo
{
    public class Produto
    {
        public int Id { get; set; }              // id_produto
        public string Nome { get; set; }         // nome
        public string Descricao { get; set; }    // descricao
        public decimal Preco { get; set; }       // preco
        public decimal Custo { get; set; }       // custo
        public bool Ativo { get; set; }          // ativo
    }
}
