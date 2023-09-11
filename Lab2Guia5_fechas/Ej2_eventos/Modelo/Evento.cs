using CalendarioClassLib.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_eventos.Modelo
{
    class Evento
    {
        Calendario calendario;
        

        public int Numero { get; private set; }

        public double ValorH { get; private set; }
        public double ValorNH { get; private set; }

        private List<Contrato> contrataciones = new List<Contrato>();

        public int TotalContratos
        {
            get 
            {
                return contrataciones.Count;
            }
        }

        public Evento(int numero, string lugar, double ValorH, double ValorNH, Calendario calendario)
        {
            this.Numero = numero;

            this.calendario = calendario;
            this.ValorH = ValorH;
            this.ValorNH = ValorNH;
        }

        public Contrato Agregar(int DNI, string nombre, DateTime inicio, DateTime fin)
        {
            Contrato nuevo = new Contrato(DNI, nombre, inicio, fin, ValorH, ValorNH, calendario);           
            contrataciones.Add(nuevo);
            return nuevo;
        }

        public Contrato VerContrato(int idx)
        {
            return contrataciones[idx];
        }
    }
}
