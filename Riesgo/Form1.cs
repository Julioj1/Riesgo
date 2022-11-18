﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riesgo
{
    public partial class Form1 : Form
    {
        ArrayList Riesgos = new ArrayList();
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Riesgo riesgo1 = new Riesgo();
            riesgo1.ID = "20220625";
            riesgo1.Name = "Julio De la Cruz";
            riesgo1.Mitigation = "Buscar un plomero que arregle el problema";
            riesgo1.Description = "Se esta filtrando el agua de el techo";
            Riesgos.Add(riesgo1);

            Riesgo riesgo2 = new Riesgo();
            riesgo2.ID = "20220781";
            riesgo2.Name = "Jose Tomas";
            riesgo2.Mitigation = "Buscar a alguien que arregle el techo";
            riesgo2.Description = "Se esta cayendo el techo";
            Riesgos.Add(riesgo2);

            dtgvRiesgo.DataSource = Riesgos;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "Debe ingresar el ID del riesgo");
                txtId.Focus();
                return;
            }
            errorProvider1.SetError(txtId, "");

            if (Existe(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Id del empleado ya a sido registrado");
                txtId.Focus();
                return;
            }

            if (txtnombre.Text == "")
            {
                errorProvider1.SetError(txtnombre, "Debe ingresar el nombre del riesgo");
                txtnombre.Focus();
                return;
            }
            errorProvider1.SetError(txtnombre, "");

            if (txtdescripción.Text == "")
            {
                errorProvider1.SetError(txtdescripción, "Debe ingresar la descripción del problema");
                txtdescripción.Focus();
                return;
            }
            errorProvider1.SetError(txtdescripción, "");

            if (rtbmitigación.Text == "")
            {
                errorProvider1.SetError(rtbmitigación, "Debe ingresar la descripción del problema");
                rtbmitigación.Focus();
                return;
            }
            errorProvider1.SetError(rtbmitigación, "");

            Riesgo miriesgo= new Riesgo();
            miriesgo.ID = txtId.Text;
            miriesgo.Name = txtnombre.Text;
            miriesgo.Description = txtdescripción.Text;
            miriesgo.Mitigation = rtbmitigación.Text;
            Riesgos.Add(miriesgo);

            dtgvRiesgo.DataSource = null;
            dtgvRiesgo.DataSource = Riesgos;

            txtId.Clear();
            txtnombre.Clear();
            txtdescripción.Clear();
            rtbmitigación.Clear();
        }

        private bool Existe(string ID)
        {
            foreach (Riesgo Riesgo in Riesgos)
            {
                if (Riesgo.ID == ID) return true;
            }
            return false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if(n != -1)
            {
                dtgvRiesgo.Rows.RemoveAt(n);
            }
        }

        private void dtgvRiesgo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if(n != -1)
            {
                lblInformation.Text = (string)dtgvRiesgo.Rows[n].Cells[0].Value;
            }
        }
    }
}