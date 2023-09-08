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

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(tbMonto.Text);
            int cantCuotas = Convert.ToInt32(nupCuotas.Value);
            DateTime fechaAltaPlan = pickerInicio.Value;
            int dni = Convert.ToInt32(tbDni.Text);
            string nombre = tbApellidosYNombres.Text;

            Infractor destinatario = new Infractor {
                                            DNI=dni,
                                            ApelldosyNombres=nombre
                                        };

            PlanDePago plan = new PlanDePago(monto, cantCuotas, fechaAltaPlan, destinatario, calendario);

            tbDetalle.Text = plan.ToString();

            /* para entender como empezar con las fechas
             
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
    }
}
