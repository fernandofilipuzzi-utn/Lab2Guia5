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
                            Infractor destinatario)
        {
            this.Destinatario = destinatario;
            this.cantidadCuotas = cantCuotas;
            this.FechaAlta = fechaAlta;

            double montoCuota = monto / cantCuotas;

            DateTime fechaMesProximo = PrimerDiaMesSiguiente(fechaAlta);

            int n = 0;
            while (n < cantCuotas)
            {
                Cuota cuota = new Cuota
                {
                    Numero = n + 1,
                    MontoBase = montoCuota,
                    PorcenVoluntario = 5,
                    FechaPrimerVenc = CalcularVencimiento(fechaMesProximo, 8),
                    FechaSegundoVenc = CalcularVencimiento(fechaMesProximo, 8)
                };

                cuotas.Add(cuota);

                //

                fechaMesProximo = PrimerDiaMesSiguiente(fechaAlta);
                n++;
            }
        }

        private DateTime PrimerDiaMesSiguiente(DateTime actual)
        {
            DateTime siguiente = new DateTime(actual.Year, actual.Month, 1).AddMonths(1);
            int dias = 0;
            if (actual.DayOfWeek == DayOfWeek.Saturday)
                dias = 2;
            else if (actual.DayOfWeek == DayOfWeek.Sunday)
                dias = 1;
            actual = actual.AddDays(dias);
            return siguiente;
        }

        private DateTime CalcularVencimiento(DateTime mesActual, int dias)
        {
            DateTime primerVenc = mesActual;
            int n = 0;
            while (n < dias)
            {
                primerVenc = mesActual.AddDays(1);
                if (primerVenc.DayOfWeek < DayOfWeek.Saturday)
                {
                    n++;
                }
            }
            return primerVenc;
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
            string linea = "";
            foreach (Cuota cuota in cuotas)
            {
                linea += cuota + "\r\n";
            }
            return linea;
        }
    }
}
