using CalendarioClassLib.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_eventos.Modelo
{
    class Contrato
    {
        Calendario calendario;

        public int DNI { get; private set; }
        public string ApellidosYNombres { get; private set; }

        public DateTime Inicio { get; private set; }
        public DateTime Fin { get; private set; }

        public double ValorHoraH
        { 
            get; private set; 
        }
        public double ValorHoraNH { get; private set; }

        public int CantHorasH 
        {
            get
            {
                int cantHorasH = 0;

                TimeSpan periodo = Fin - Inicio;

                DateTime dia = Inicio;
                int n = 0;
                do
                {
                    if (dia.DayOfWeek < DayOfWeek.Saturday)
                        cantHorasH += 8;

                    dia = dia.AddDays(1);
                    n++;
                } while (n < periodo.Days + 1);

                return cantHorasH;
            }
        }

        public int CantHorasNH
        {
            get
            {
                int cantHorasNH = 0;

                TimeSpan periodo = Fin - Inicio;

                DateTime dia = Inicio;
                int n = 0;
                do
                {
                    if (dia.DayOfWeek == DayOfWeek.Saturday ||
                            (calendario!=null && calendario.Fechas().Contains(dia) == true))
                        cantHorasNH += 8;

                    dia = dia.AddDays(1);
                    n++;
                } while (n < periodo.Days + 1);
                
                return cantHorasNH;
            }
        }

        public double TotalHoraH
        {
            get 
            {
                return CantHorasH * ValorHoraH;
            }
        }
        public double TotalHoraNH
        {
            get
            {
                return CantHorasNH * ValorHoraNH;
            }
        }

        public double Nominal
        {
            get
            {
                return TotalHoraH+ TotalHoraNH;
            }
        }
        public double AporPrevisional
        {
            get
            {
                return Nominal*5/100;
            }
        }
        public double AporVoluntario
        {
            get
            {
                return Nominal * 15 / 100;
            }
        }
        public double TotalACobrar 
        {
            get
            { 
                return Nominal - AporPrevisional - AporVoluntario;
            }
        }

        public Contrato(int DNI, string nombre, DateTime inicio, DateTime fin,
                        double ValorH, double ValorNH,
                        Calendario calendario)
        {
            this.DNI = DNI;
            this.ApellidosYNombres = nombre;
            this.Inicio = inicio;
            this.Fin = fin;
            this.ValorHoraH = ValorH;
            this.ValorHoraNH = ValorNH;
            this.calendario = calendario;
        }

        public string VerRecibo()
        {
            string recibo = "";
            string detalle;

            recibo += $"Apellidos, Nombres(DNI: {DNI}): {ApellidosYNombres} \r\n";
            recibo += $"Periodo de contratación: Inicio: {Inicio:d/M/yy} -  {Fin:d/M/yy}\r\n";

            detalle = $"Valor Hora en día hábil({CantHorasH:f2} hr, {ValorHoraH:f2} $/hr) $";
            recibo += $"{detalle,-60}{TotalHoraH,10:f2}\r\n";

            detalle = $"Valor Hora día no hábil({CantHorasNH:f2} hr,{ValorHoraNH:f2} $/hr) $";
            recibo += $"{detalle,-60}{TotalHoraNH,10:f2}\r\n";

            detalle = $"Nominal(SubTotal) $";
            recibo += $"{detalle,-60}{Nominal,10:f2}\r\n\r\n";


            detalle = $"Aportes Previsionales(-5 %) $";
            recibo += $"{detalle,-60}{AporPrevisional,10:f2}\r\n";

            detalle = $"Aportes Voluntarios(-15 %) $";
            recibo += $"{detalle,-60}{AporVoluntario,10:f2}\r\n";

            detalle = $"Total a Cobrar $";
            recibo += $"{detalle,-60}{TotalACobrar,10:f2}\r\n";

            return recibo;
        }
    }
}
