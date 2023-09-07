using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_plan_de_pagos.Modelo
{
    class Cuota
    {
        public int Numero { get; set; }
        public double MontoBase { get; set; }
        public double PorcenVoluntario { get; set; }
        public double MontoVoluntario
        {
            get
            {
                return MontoBase * PorcenVoluntario / 100;
            }
        }
        public DateTime FechaPrimerVenc { get; set; }
        public double MontoPrimerVenc 
        {
            get 
            {
                return MontoBase + MontoVoluntario;
            }
        }
        public DateTime FechaSegundoVenc { get; set; }

        public double MontoSegundoVenc 
        {
            get 
            {
                return MontoBase + MontoVoluntario;
            } 
        }

        public double SobreCargoMontoSegundoVenc
        {
            get
            {
                return MontoSegundoVenc * 20 / 100;
            }
        }

        public double MontoSegundoVencConSobr
        {
            get
            {
                return MontoSegundoVenc + SobreCargoMontoSegundoVenc;
            }
        }

        public override string ToString()
        {
            string linea = $"Cuota número {Numero} -  Valor Cuota {MontoBase} \r\n" +
                           
                            $"Donación voluntaria {PorcenVoluntario}% -  ${MontoVoluntario,10:f2} \r\n" +

                           $"Primer Vencimiento ({FechaPrimerVenc:dd/MM/yy})  ${MontoPrimerVenc,10:f2}\r\n" +
                           "\r\n"+
                           $"Segundo Vencimiento ({FechaSegundoVenc:dd/MM/yy})  ${MontoSegundoVenc,10:f2}\r\n";
            //faltan cosas

            return linea;
        }
    }
}
