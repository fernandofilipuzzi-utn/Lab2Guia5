using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_plan_de_pagos.Modelo
{
    class Infractor
    {
        public int DNI { get; set; }
        public string ApelldosyNombres { get; set; }

        public override string ToString()
        {
            return $"{ApelldosyNombres}({DNI})";
        }
    }
}
