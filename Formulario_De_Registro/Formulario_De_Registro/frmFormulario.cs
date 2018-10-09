using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Formulario_De_Registro
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private List<String> listaDatos;

        private void Limpiar()
        {
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtEstado.Clear();
            txtMunicipio.Clear();
            txtNo.Clear();
            txtNombre.Clear();
            barraEscrito.Value = 0;
            barraHablado.Value = 0;
            lblHabladoPorcentaje.Text = "0 %";
            lblPorcentajeEscrito.Text = "0 %";
        }

        private void CrearDocumento()
        {
            File.AppendAllText(@".\croquetas.txt","C1: " + txtNombre.Text + "\r\n" 
            + "C2: " +txtApellidos.Text + "\r\n" + "C3: " + "Fecha de nacimiento: " + dateTimePicker1.Text + "\r\n" + "C4: " + txtDireccion.Text + "No. " + txtNo.Text + "\r\n"
            + "C5: " + txtMunicipio.Text + ", " + txtEstado.Text + "\r\n" + "Ingles hablado: " + barraHablado.Value.ToString() + "%" + "\r\n" + "Ingles escrito: " + barraEscrito.Value.ToString() + "%"
            + "\r\n");
        }

        private void CargaDatos()
        {

            List<string> lista = new List<string>(File.ReadAllLines(@".\croquetas.txt"));
            for (int i = 0; i < lista.Count; i+=7)
            {
                string[] arreglo = new string[7];
                for (int j = 0; j < 7 ; j++)
                {
                    arreglo[j] = lista[j + i];
                }
                dgvDatos.Rows.Add(arreglo);
            }
        }

        private void PasarDatosAFormulario()
        {
            MessageBox.Show(File.ReadAllText(@".\croquetas.txt"));
            if (dgvDatos.Columns[0].row)
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void barraHablado_Scroll(object sender, EventArgs e)
        {
            lblHabladoPorcentaje.Text = barraHablado.Value.ToString() + " %";
        }

        private void barraEscrito_Scroll(object sender, EventArgs e)
        {
            lblPorcentajeEscrito.Text = barraEscrito.Value.ToString() + " %";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtApellidos.Text == "" || txtDireccion.Text == "" || txtEstado.Text == "" || txtMunicipio.Text == "" || txtNo.Text == "" || txtNombre.Text== "")
            {
                MessageBox.Show("Faltan campos por llenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CrearDocumento();
                MessageBox.Show("Datos guardados", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Limpiar();
            }
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
                CargaDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PasarDatosAFormulario();
        }
    }
}