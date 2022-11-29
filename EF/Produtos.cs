using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMVC.EF
{
    public class Produtos
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Valores { get; set; }
        public int Quantidade { get; set; }
    }
}
