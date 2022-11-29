using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMVC.EF
{
    public class Estoques
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public string LocalArmazenado { get; set; }

        public string SaidaProduto { get; set; }

        public string EntradaProduto { get; set; }

        public DateTime EntradaData { get; set; }

        public DateTime RetiradaData { get; set; }
    }
}
