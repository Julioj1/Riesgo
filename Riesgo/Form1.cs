using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Riesgo
{
    public partial class Form1 : Form
    {
        List <Riesgo> Riesgos = new List<Riesgo>();
        private int n = 0;
        int nProbabilidad = 0;
        int nImpacto = 0;
        int Calculo = 0;
        string vl;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Riesgo riesgo1 = new Riesgo();
            //riesgo1.ID = "20220625";
            //riesgo1.Name = "Julio De la Cruz";
            //riesgo1.Mitigation = "Buscar un plomero que arregle el problema";
            //riesgo1.Description = "Se esta filtrando el agua de el techo";
            //Riesgos.Add(riesgo1);

            //Riesgo riesgo2 = new Riesgo();
            //riesgo2.ID = "20220781";
            //riesgo2.Name = "Jose Tomas";
            //riesgo2.Mitigation = "Buscar a alguien que arregle el techo";
            //riesgo2.Description = "Se esta cayendo el techo";
            //Riesgos.Add(riesgo2);

            if (File.Exists("Riesgos.xml"))
            {
                XmlSerializer Serializador = new XmlSerializer(typeof(List<Riesgo>));
                FileStream Lector = File.OpenRead("Riesgos.xml");
                Riesgos = (List<Riesgo>)Serializador.Deserialize(Lector);
                Lector.Close();
            }
           


            dtgvRiesgo.DataSource = Riesgos;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;

            if (Existe(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Id del empleado ya a sido registrado");
                txtId.Focus();
                return;
            }
            calculo_total();
            Riesgo miriesgo= new Riesgo();
            miriesgo.ID = txtId.Text;
            miriesgo.Name = txtnombre.Text;
            miriesgo.Description = txtdescripción.Text;
            miriesgo.Mitigation = rtbmitigación.Text;
            miriesgo.Probabilidad = lstbProbabilidad.Text;
            miriesgo.Impacto = lstbImpacto.Text;
            miriesgo.Total = Calculo;
            miriesgo.Nivel = vl;
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
            DialogResult rta = MessageBox.Show(this, "Esta seguro de borrar el riesgo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            if (!ValidarID()) return;
            
            if (GetRiesgo(txtId.Text) == null)
            {
                errorProvider1.SetError(txtId, "Persona no existe");
                txtId.Focus();
                return;
            }
            errorProvider1.SetError(txtId, "");

            foreach ( Riesgo miRiesgo in Riesgos)
            {
                if (miRiesgo.ID == txtId.Text)
                {
                    Riesgos.Remove(miRiesgo);
                    break;
                }
            }
            btnlimpiar_Click(sender, e);
            dtgvRiesgo.DataSource = null;
            dtgvRiesgo.DataSource = Riesgos;

        }

        private void dtgvRiesgo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if(n != -1)
            {
                lblInformation.Text = (string)dtgvRiesgo.Rows[n].Cells[0].Value;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;

            Riesgo miRiesgo = GetRiesgo(txtId.Text);
            if (miRiesgo == null)
            {
                errorProvider1.SetError(txtId, "Riesgo no existe");
                txtId.Focus();
                return;
            }
            errorProvider1.SetError(txtId, "");

            txtId.Text = miRiesgo.ID;
            txtnombre.Text = miRiesgo.Name;
            txtdescripción.Text = miRiesgo.Description;
            rtbmitigación.Text = miRiesgo.Mitigation;
        }

        private bool ValidarID()
        {
            if (txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "Debe ingresar el ID del riesgo");
                txtId.Focus();
                return false;
            }
            errorProvider1.SetError(txtId, "");
            return true;
        }
        private Riesgo GetRiesgo(string ID)
        {
            foreach (Riesgo miRiesgo in Riesgos)
            {
                if (miRiesgo.ID == ID) return miRiesgo;
            }
            return null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;

            if (GetRiesgo(txtId.Text) == null)
            {
                errorProvider1.SetError(txtId, "Riesgo no existe");
                txtId.Focus();
                return;
            }
            errorProvider1.SetError(txtId, "");

            if (!ValidarOtrosCampos()) return;
            calculo_total();
            foreach (Riesgo miRiesgo in Riesgos)
            {
                if (miRiesgo.ID == txtId.Text)
                {
                    miRiesgo.Name = txtnombre.Text;
                    miRiesgo.Description = txtdescripción.Text;
                    miRiesgo.Mitigation = rtbmitigación.Text;
                    miRiesgo.Impacto = lstbImpacto.Text;
                    miRiesgo.Probabilidad = lstbProbabilidad.Text;
                    miRiesgo.Total = Calculo;
                    miRiesgo.Nivel = vl;
                    break;
                }
               
            }
            dtgvRiesgo.DataSource = null;
            dtgvRiesgo.DataSource = Riesgos;

        }

        private bool ValidarOtrosCampos()
        {
            if (txtnombre.Text == "")
            {
                errorProvider1.SetError(txtnombre, "Debe ingresar el nombre del riesgo");
                txtnombre.Focus();
                return false;
            }
            errorProvider1.SetError(txtnombre, "");

            if (txtdescripción.Text == "")
            {
                errorProvider1.SetError(txtdescripción, "Debe ingresar la descripción del problema");
                txtdescripción.Focus();
                return false;
            }
            errorProvider1.SetError(txtdescripción, "");

            if (rtbmitigación.Text == "")
            {
                errorProvider1.SetError(rtbmitigación, "Debe ingresar la descripción del problema");
                rtbmitigación.Focus();
                return false;
            }
            errorProvider1.SetError(rtbmitigación, "");

            return true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtnombre.Clear();
            txtdescripción.Clear();
            rtbmitigación.Clear();
        }
        private void calculo_total()
        {
            nProbabilidad = Convert.ToInt16(lstbProbabilidad.Text);
            nImpacto = Convert.ToInt16(lstbImpacto.Text);
            Calculo = nProbabilidad * nImpacto;
            if (Calculo >= 1 && Calculo <= 5)
            {
                vl = "1-Riesgo muy bajo";
                dtgvRiesgo.Rows[n].Cells[7].Style.BackColor = Color.GreenYellow; 
                dtgvRiesgo.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 6 && Calculo <= 10)
            {
                vl = "2-Riesgo bajo";
                dtgvRiesgo.Rows[n].Cells[7].Style.BackColor = Color.Green;
                dtgvRiesgo.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 11 && Calculo <= 15)
            {
                vl = "3-Riesgo normal";
                dtgvRiesgo.Rows[n].Cells[7].Style.BackColor = Color.Orange;
                dtgvRiesgo.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
            if (Calculo >= 16 && Calculo <= 20)
            {
                vl = "4-Riesgo alto";
                dtgvRiesgo.Rows[n].Cells[7].Style.BackColor = Color.OrangeRed;
                dtgvRiesgo.Rows[n].Cells[7].Style.ForeColor = Color.White;


            }
            if (Calculo >= 21 && Calculo <= 25)
            {
                vl = "5-Riesgo muy alto";
                dtgvRiesgo.Rows[n].Cells[7].Style.BackColor = Color.Red;
                dtgvRiesgo.Rows[n].Cells[7].Style.ForeColor = Color.White;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer Serializador = new XmlSerializer(typeof(List<Riesgo>));
            TextWriter escritor = new StreamWriter ("Riesgos.xml");
            Serializador.Serialize(escritor, Riesgos);
        }

    }
}
