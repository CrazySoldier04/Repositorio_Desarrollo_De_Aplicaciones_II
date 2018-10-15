using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibORM;

namespace ORM
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        string cadena;
        DataTable bases;
        DataTable tablas;
        DataTable campos;
        string db;
        string tb;
        MySQL My = new MySQL();

        private void cbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMotor.SelectedIndex == 0)
            {
                txtHost.Text = "127.0.0.1";
                txtUsuario.Text = "root";
                txtPuerto.Text = "3306";
            }
            else if (cbMotor.SelectedIndex == 1)
            {
                txtHost.Text = "localhost";
                txtUsuario.Text = "sa";
                txtPuerto.Text = "1433";
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                txtHost.Text = "127.0.0.1";
                txtUsuario.Text = "postgres";
                txtPuerto.Text = "5432";
            }
            /*else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }*/
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (cbMotor.SelectedIndex == 0)
            {
                MySQL();
            }
            else if (cbMotor.SelectedIndex == 1)
            {
                MsSQL();
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                PostgreSQL();
            }
            else if (cbMotor.SelectedIndex == 3)
            {
                FoxPro();
            }
            else
            {
                MessageBox.Show("Seleccione un Motor de Base de Datos");
            }
        }

        private void MySQL()
        {
            cadena = "server=" + txtHost.Text + ";port=" + txtPuerto.Text + ";user=" + txtUsuario.Text + ";password=" + txtPass.Text;
            if (My.Conexion(cadena))
            {
                MessageBox.Show("Conexion Exitosa");
                bases = My.ConsultaDT(cadena, "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA");
                lbString.Text = cadena;
                cbBases.DataSource = bases;
                cbBases.DisplayMember = "SCHEMA_NAME";
                cbBases.ValueMember = "SCHEMA_NAME";

                cbTablas.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error de Conexion");
            }
        }

        private void MsSQL()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void PostgreSQL()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FoxPro()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (cbTipoDato.SelectedIndex == 0)//Muestra la estructura de la bd (Tablas)
            {
                cbTablas.Enabled = false;
                tablas = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.TABLES WHERE INFORMATION_SCHEMA.TABLES.TABLE_SCHEMA LIKE '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = tablas;
            }
            else if (cbTipoDato.SelectedIndex == 1)// Muestra La estructura de las tablas.
            {
                cbTablas.Enabled = true;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.columns where columns.table_NAME = '" + tb + "' AND TABLE_SCHEMA = '"+ db +"';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 2)//Muestra los indices
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.statistics WHERE table_schema = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 3)//Mustra las relaciones o constrains
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.table_constraints where constraint_schema = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 4)//Mustra los Store Procedures
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM INFORMATION_SCHEMA.ROUTINES where routine_schema  = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 5)//Muestra las vistas
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT *  FROM information_schema.tables WHERE TABLE_TYPE LIKE 'VIEW' AND TABLE_SCHEMA LIKE '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 6) //Muestra los triggers
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.triggers where information_schema.triggers.trigger_schema like '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
        }

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb = cbTablas.SelectedValue.ToString();
        }

        private void cbBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = cbBases.SelectedValue.ToString();
            tablas = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.TABLES WHERE INFORMATION_SCHEMA.TABLES.TABLE_SCHEMA LIKE '" + db + "';"); //+  //"USE " + cbBases.SelectedText + "; SHOW TABLES;");
            cbTablas.DataSource = tablas;
            cbTablas.DisplayMember = "TABLE_NAME";
            cbTablas.ValueMember = "TABLE_NAME";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDato.SelectedIndex == 1)
            {
                cbTablas.Enabled = true;
            }
            else
            {
                cbTablas.Enabled = false;
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
