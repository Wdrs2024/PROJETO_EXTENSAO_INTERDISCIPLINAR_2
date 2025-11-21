using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ped_Hospitalar.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }           // id_usuario
        public string Nome { get; set; }      // nome
        public string Login { get; set; }     // login
        public string Senha { get; set; }     // senha
        public string Perfil { get; set; }    // perfil (admin, vendedor, etc.)
    }
}