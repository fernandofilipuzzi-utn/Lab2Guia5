﻿
namespace Ej1_plan_de_pagos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbApellidosYNombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCalendario = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nupCuotas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.pickerInicio = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.lbxPlanesGenerados = new System.Windows.Forms.ListBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(219, 207);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(176, 36);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Ingresar Plan de pagos";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar Feriados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregarFeriado_Click);
            // 
            // tbApellidosYNombres
            // 
            this.tbApellidosYNombres.Location = new System.Drawing.Point(163, 43);
            this.tbApellidosYNombres.Name = "tbApellidosYNombres";
            this.tbApellidosYNombres.Size = new System.Drawing.Size(200, 22);
            this.tbApellidosYNombres.TabIndex = 15;
            this.tbApellidosYNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidosYNombres_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbApellidosYNombres);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellidos y Nombres";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(163, 15);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(200, 22);
            this.tbDni.TabIndex = 18;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI";
            // 
            // dtCalendario
            // 
            this.dtCalendario.Location = new System.Drawing.Point(617, 311);
            this.dtCalendario.Name = "dtCalendario";
            this.dtCalendario.TabIndex = 17;
            this.dtCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nupCuotas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMonto);
            this.groupBox2.Controls.Add(this.pickerInicio);
            this.groupBox2.Location = new System.Drawing.Point(32, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 106);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "En Cuotas:";
            // 
            // nupCuotas
            // 
            this.nupCuotas.Location = new System.Drawing.Point(159, 46);
            this.nupCuotas.Name = "nupCuotas";
            this.nupCuotas.Size = new System.Drawing.Size(68, 22);
            this.nupCuotas.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto de la infracción";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(159, 18);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(204, 22);
            this.tbMonto.TabIndex = 18;
            this.tbMonto.TextChanged += new System.EventHandler(this.tbMonto_TextChanged);
            this.tbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonto_KeyPress);
            // 
            // pickerInicio
            // 
            this.pickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerInicio.Location = new System.Drawing.Point(159, 74);
            this.pickerInicio.Name = "pickerInicio";
            this.pickerInicio.Size = new System.Drawing.Size(106, 22);
            this.pickerInicio.TabIndex = 16;
            // 
            // tbDetalle
            // 
            this.tbDetalle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalle.Location = new System.Drawing.Point(29, 250);
            this.tbDetalle.Multiline = true;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(579, 229);
            this.tbDetalle.TabIndex = 21;
            // 
            // lbxPlanesGenerados
            // 
            this.lbxPlanesGenerados.FormattingEnabled = true;
            this.lbxPlanesGenerados.ItemHeight = 16;
            this.lbxPlanesGenerados.Location = new System.Drawing.Point(621, 23);
            this.lbxPlanesGenerados.Name = "lbxPlanesGenerados";
            this.lbxPlanesGenerados.Size = new System.Drawing.Size(244, 196);
            this.lbxPlanesGenerados.TabIndex = 22;
            this.lbxPlanesGenerados.SelectedIndexChanged += new System.EventHandler(this.lbxPlanesGenerados_SelectedIndexChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 491);
            this.Controls.Add(this.lbxPlanesGenerados);
            this.Controls.Add(this.tbDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtCalendario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de plan de pagos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbApellidosYNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar dtCalendario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.DateTimePicker pickerInicio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupCuotas;
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.ListBox lbxPlanesGenerados;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

