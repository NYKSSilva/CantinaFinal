using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Cantina;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina
{
    public class Itens
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        //public double total => Valor * Quantidade;
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return $"{Nome} - R${Valor} - x{Quantidade}";
        }


    }
}
