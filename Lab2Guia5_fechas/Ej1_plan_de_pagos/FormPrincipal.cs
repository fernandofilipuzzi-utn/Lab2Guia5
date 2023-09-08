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
            if (Validar() == true)
            {
                int dni = Convert.ToInt32(tbDni.Text);
                string nombre = tbApellidosYNombres.Text;
                double monto = Convert.ToDouble(tbMonto.Text);
                int cantCuotas = Convert.ToInt32(nupCuotas.Value);
                DateTime fechaAltaPlan = pickerInicio.Value;
                
                Infractor destinatario = new Infractor
                {
                    DNI = dni,
                    ApelldosyNombres = nombre
                };

                PlanDePago plan = new PlanDePago(monto, cantCuotas, fechaAltaPlan,
                                                    destinatario, calendario);

                tbDetalle.Text = plan.VerDetalle();

                lbxPlanesGenerados.Items.Add(plan);

                #region limpiando controles
                tbDni.Clear();
                tbApellidosYNombres.Clear();
                tbMonto.Clear();
                nupCuotas.Value = 0;
                #endregion
            }
        }

        public bool Validar()
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDni.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDni.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbApellidosYNombres.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbApellidosYNombres.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbMonto.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbMonto.BackColor = Color.Orange;
            }

            return isNoOk==false;
        }

        private void tbDni_TextChanged(object sender, EventArgs e)
        {
            tbDni.BackColor = Color.White;
        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            tbMonto.BackColor = Color.White;
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) ||  char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbApellidosYNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbApellidosYNombres.BackColor = Color.White;
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' ||
                    char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lbxPlanesGenerados_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanDePago plan = lbxPlanesGenerados.SelectedItem as PlanDePago;
            
            if(plan !=null)
                tbDetalle.Text = plan.VerDetalle();
        }



        /*
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            DateTime dtInicioPago = pickerInicio.Value;

            DateTime dtInicioPlan = new DateTime(dtInicioPago.Year, dtInicioPago.Month, 1).AddMonths(1);

            int dias = 0;
            if (dtInicioPlan.DayOfWeek == DayOfWeek.Saturday)
                dias = 2;
            else if (dtInicioPlan.DayOfWeek == DayOfWeek.Sunday)
                dias = 1;
            dtInicioPlan = dtInicioPlan.AddDays(dias);

            DateTime dtPrimerVencimiento = dtInicioPlan.AddDays(8 - 1);

            tbDetalle.ClearSelected();
            tbDetalle.Items.Clear();

            tbDetalle.Items.Add(dtInicioPlan.ToShortDateString());

            tbDetalle.Items.Add(dtPrimerVencimiento.ToShortDateString());

            DateTime dtSegundoVencimiento = dtInicioPlan.AddDays(15 - 1);
            tbDetalle.Items.Add(dtSegundoVencimiento.ToShortDateString());
        }
        */
    }
}
