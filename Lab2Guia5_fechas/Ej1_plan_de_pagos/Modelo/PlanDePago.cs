using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_plan_de_pagos.Modelo
{
    class PlanDePago
    {
        public Infractor Destinatario { get; private set; }

        public List<Cuota> cuotas = new List<Cuota>();

        private int cantidadCuotas;
        public int CantidadCuotas
        {
            get
            {
                return cantidadCuotas;
            }
        }

        public DateTime FechaAlta { get; private set; }

        public PlanDePago(double monto, int cantCuotas, DateTime fechaAlta,
                            Infractor destinatario,  Calendario calendario)
        {
            this.Destinatario = destinatario;
            this.cantidadCuotas = cantCuotas;
            this.FechaAlta = fechaAlta;

            double montoCuota = monto / cantCuotas;

            DateTime fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaAlta, calendario);

            int nroCuota = 1;
            while (nroCuota <= cantCuotas)
            {
                DateTime primerVenc = CalcularFechaVencimiento(fechaMesProximo, 8, calendario);
                DateTime segundoVenc = CalcularFechaVencimiento(primerVenc, 15+1, calendario);

                Cuota cuota = new Cuota
                {
                    Numero = nroCuota,
                    MontoBase = montoCuota,
                    PorcenVoluntario = 5,
                    FechaPrimerVenc = primerVenc,
                    PorcenSegundoVenc=20,
                    FechaSegundoVenc = segundoVenc
                };

                cuotas.Add(cuota);

                fechaMesProximo = PrimerDiaHabilMesSiguiente(fechaMesProximo, calendario);
                nroCuota++;
            }
        }

        private DateTime PrimerDiaHabilMesSiguiente(DateTime actual, Calendario feriados)
        {
            DateTime siguiente = new DateTime(actual.Year, actual.Month, 1).AddMonths(1);
            siguiente = DeterminarDiaHabil(siguiente, feriados);
            return siguiente;
        }

        private DateTime DeterminarDiaHabil(DateTime actual, Calendario feriados)
        {
            if (actual.DayOfWeek == DayOfWeek.Saturday || 
                actual.DayOfWeek == DayOfWeek.Sunday ||
                feriados.Buscar(actual) != null )
            {
                actual = DeterminarDiaHabil(actual.AddDays(1), feriados);
            }
            return actual;
        }

        private DateTime CalcularFechaVencimiento(DateTime mesActual, int cantDiasHabiles, Calendario feriados)
        {
            DateTime venc = mesActual;

            int diasHabiles = 1;
            while (diasHabiles < cantDiasHabiles)
            {
                venc = DeterminarDiaHabil(venc.AddDays(1), feriados);
                diasHabiles++;
            }

            return venc;
        }

        public Cuota VerCuota(int idx)
        {
            Cuota cuota = null;

            if (idx >= 0 && idx < CantidadCuotas)
                cuota = cuotas[idx];

            return cuota;
        }

        public override string ToString()
        {
            return $"Plan de pagos: {Destinatario.ApelldosyNombres}";
        }

        public string VerDetalle() 
        {
            string linea = $"Destinatario: {Destinatario}\r\n" +
                            "\r\n";

            foreach (Cuota cuota in cuotas)
            {
                linea += cuota + "\r\n";
            }
            return linea;
        }
    }
}
