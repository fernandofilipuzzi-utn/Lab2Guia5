using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_eventos.Modelo
{
    class Empresa
    {
        List<Evento> eventos = new List<Evento>();

        int numeroEvento;
        
        public int CantEventos
        {
            get
            {
                return eventos.Count;
            }
        }

        public Empresa() { }


        public Evento RegistrarEvento(string lugar)
        {
            Evento evento = new Evento(numeroEvento++, lugar, 1, 1);

            eventos.Add(evento);

            return evento;
        }

        public Evento VerEvento(int idx)
        {
            return eventos[idx];
        }
    }
}
