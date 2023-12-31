﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using Ej2_eventos.Modelo;
using CalendarioClassLib.Modelo;

namespace Ej2_eventos
{
    public partial class FormPrincipal : Form
    {
        Calendario calendario = new Calendario();

        public FormPrincipal()
        {
            InitializeComponent();
        }
                
        private void FormPrincipal_Load(object sender, EventArgs e)
        {            
        }

        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            FormDatosFeriado fDatoFeriado = new FormDatosFeriado();

            if (fDatoFeriado.ShowDialog() == DialogResult.OK)
            {
                DateTime dia = fDatoFeriado.pickFecha.Value;
                string descripcion = fDatoFeriado.tbDescripcion.Text;
             
                calendario.AgregarFeriado(dia, descripcion);
                dtCalendario.BoldedDates = calendario.Fechas();
            }
        }
        
        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = dtCalendario.SelectionStart;

            Feriado consulta = calendario.Buscar(selectedDate);

            if (consulta != null)
            {
                toolTip1.SetToolTip(dtCalendario, consulta.Descripcion);
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            
            double valorH = 234.23;//
            double valorNH = 434.23;//

            Evento nuevo = empresa.RegistrarEvento("Paraná", valorH, valorNH, calendario);

            nuevo.Agregar(23432432, "Hernandez, Juan",new DateTime(2023, 9, 3), new DateTime(2023, 9, 9));
            nuevo.Agregar(23432432, "Mores, Mariano", new DateTime(2023, 9, 8), new DateTime(2023, 9, 9));

            for (int n = 0; n < nuevo.TotalContratos; n++)
            {
                textBox1.Text += nuevo.VerContrato(n).VerRecibo() + "\r\n";
            }

        }
    }
}
