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
        public DateTime FechaAlta { get; private set; }

        public PlanDePago(double monto, int cantCuotas, DateTime fechaAlta,
                            Infractor destinatario)
        {
            Destinatario = destinatario;

            this.FechaAlta = fechaAlta;

            double montoCuota = monto / cantCuotas;                     

            DateTime inicio = fechaAlta;

            for (int n = 0; n < cantCuotas; n++)
            {
                #region primer vencimiento
                DateTime fechaInicioMes = new DateTime(inicio.Year, inicio.Month, 1).AddMonths(1);
                int dias = 0;
                if (fechaInicioMes.DayOfWeek == DayOfWeek.Saturday)
                    dias = 2;
                else if (fechaInicioMes.DayOfWeek == DayOfWeek.Sunday)
                    dias = 1;
                fechaInicioMes = fechaInicioMes.AddDays(dias);
                DateTime fechaPrimerVencimiento = fechaInicioMes.AddDays(8 - 1);
                #endregion

                Cuota cuota = new Cuota
                {
                    FechaPrimerVencimiento = fechaPrimerVencimiento
                };

                //para la siguiente
                inicio = fechaPrimerVencimiento;
            }
        }
    }
}
