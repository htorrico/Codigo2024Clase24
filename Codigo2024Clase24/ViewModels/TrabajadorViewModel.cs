using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase24
{
    public class TrabajadorViewModel
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public int TipoContrato { get; set; }
        public double SueldoBruto { get; set; }
        public double SueldoNeto { get; set; }

        public double Impuesto { get; set; }

        private void CalcularImpuesto()
        {
            if (TipoContrato==1)
            {
                //Lógica de 4TA Categoria
                double SueldoAnual = 0;
                SueldoAnual = SueldoBruto * 12;

                if (SueldoAnual>3500)
                {
                    Impuesto = SueldoBruto * 0.08;
                }


            }
            else
            {

            }


        }



    }
}
