using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ped_Hospitalar.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }          // id_cliente
        public string Nome { get; set; }     // nome
        public string Endereco { get; set; } // endereco
        public string Telefone { get; set; } // telefone
        public string Email { get; set; }    // email
    }
}
