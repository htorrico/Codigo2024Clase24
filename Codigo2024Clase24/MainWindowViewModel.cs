using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase24
{
    public class MainWindowViewModel
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public int ResultadoSuma { get; set; }
        public void Sumar()
        {
            ResultadoSuma = Valor1 + Valor2;
        }
    }
}
