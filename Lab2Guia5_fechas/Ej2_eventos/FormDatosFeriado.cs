using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2_eventos
{
    public partial class FormDatosFeriado : Form
    {
        public FormDatosFeriado()
        {
            InitializeComponent();
        }

        private void FormDatosFeriado_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDescripcion.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDescripcion.BackColor = Color.Orange;
            }

            /*
            if (pickFecha.Value!=null)
            {
                isNoOk |= true;
                pickFecha.BackColor = Color.Orange;
            }
            */

            if (isNoOk == false)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.None;
        }

       

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            tbDescripcion.BackColor = Color.White;
        }

        private void pickFecha_ValueChanged(object sender, EventArgs e)
        {
            pickFecha.BackColor = Color.White;
        }
    }
}
