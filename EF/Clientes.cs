using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMVC.EF
{
    public class Clientes
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public string UF { get; set; }
    }
}
