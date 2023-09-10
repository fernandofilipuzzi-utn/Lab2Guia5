using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_eventos.Modelo
{
    class Evento
    {
        public double ValorH { get; private set; }
        public double ValorNH { get; private set; }

        private List<Contrato> contrataciones = new List<Contrato>();

        public Evento(int numero, string lugar, double ValorH, double ValorNH)
        { 
        }

        public Contrato Agregar(int DNI, string nombre, 
                                DateTime inicio, DateTime fin,
                                int CantH, int CantNH)
        {
            Contrato nuevo = new Contrato(DNI, nombre, inicio, fin,
                                        CantH, ValorH, CantNH, ValorNH);

            contrataciones.Add(nuevo);
            return nuevo;
        }
    }
}
