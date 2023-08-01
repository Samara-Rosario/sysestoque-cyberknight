using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_cyberknight.Models
{
    internal class ItemEntrada{
        public NotaEntrada  notaEntrada { get; set; }
        public Produto produto { get; set; }
        public int Qtd { get; set; }
    }
}
