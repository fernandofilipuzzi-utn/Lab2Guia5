using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using Ej1_plan_de_pagos.Modelo;


namespace Ej1_plan_de_pagos
{
    public partial class FormPrincipal : Form
    {
        List<Feriado> feriados = new List<Feriado>();

        public Feriado Buscar(DateTime fecha)
        {
            Feriado buscado = null;
            int n = 0;
            while (n < feriados.Count && buscado == null)
            {
                if (feriados[n].Dia.Year == fecha.Year && feriados[n].Dia.Month == fecha.Month && feriados[n].Dia.Day == fecha.Day)
                //if(fecha.CompareTo(feriados[n].Dia)==0) ojo aquí!
                    buscado = feriados[n];
                n++;
            }
            return buscado;
        }
        public DateTime[] Fechas()
        {
            DateTime[] fechas = new DateTime[feriados.Count];
            int n = 0;
            while (n < feriados.Count)
            {
                fechas[n] = feriados[n].Dia;
                n++;
            }
            return fechas;
        }


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
                Feriado feriado = new Feriado()
                {
                    Dia = fDatoFeriado.pickFecha.Value,
                    Descripcion = fDatoFeriado.tbDescripcion.Text,
                };
                feriados.Add(feriado);
                calendario.BoldedDates = Fechas();
            }
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calendario.SelectionStart;

            Feriado consulta = Buscar(selectedDate);

            if (consulta != null)
            {
                toolTip1.SetToolTip(calendario, consulta.Descripcion);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /*
            DateTime dtInicioPago = pickerInicio.Value;

            DateTime dtInicioPlan = new DateTime(dtInicioPago.Year, dtInicioPago.Month, 1).AddMonths(1);

            int dias = 0;
            if (dtInicioPlan.DayOfWeek == DayOfWeek.Saturday)
                dias = 2;
            else if (dtInicioPlan.DayOfWeek == DayOfWeek.Sunday)
                dias = 1;
            dtInicioPlan = dtInicioPlan.AddDays(dias);

            DateTime dtPrimerVencimiento = dtInicioPlan.AddDays(8 - 1);

            listBox1.ClearSelected();
            listBox1.Items.Clear();

            listBox1.Items.Add(dtInicioPlan.ToShortDateString());

            listBox1.Items.Add(dtPrimerVencimiento.ToShortDateString());

            DateTime dtSegundoVencimiento = dtInicioPlan.AddDays(15 - 1);
            listBox1.Items.Add(dtSegundoVencimiento.ToShortDateString());

            */
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
