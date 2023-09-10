using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioClassLib.Modelo
{
    public class Feriado
    {
        public DateTime Dia { get; set; }

        public string Descripcion { get; set; }
        
        public bool CompararDia(DateTime day)
        {
            return day != null && Dia!=null && day.Year == Dia.Year && day.Month == Dia.Month && day.Day == Dia.Day;
        }
    }
}
