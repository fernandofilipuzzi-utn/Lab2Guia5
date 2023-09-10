using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_eventos.Modelo
{
    class Contrato
    {
        public int DNI { get; private set; }
        public string ApellidosYNombres { get; private set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fin { get; private set; }
        public double ValorHoraH { get; private set; }
        public double ValorHoraNH { get; private set; }

        public int CantHorasH { get; set; }
        public int CantHorasNH { get; set; }
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
                        int CantH, double ValorH, int CantNH, double ValorNH)
        {
            this.DNI = DNI;
            this.ApellidosYNombres = nombre;
            this.Inicio = inicio;
            this.Fin = fin;
            this.CantHorasH = CantH;
            this.ValorHoraH = ValorH;
            this.CantHorasNH = CantNH;
            this.ValorHoraNH = ValorNH;
        }
    }
}
