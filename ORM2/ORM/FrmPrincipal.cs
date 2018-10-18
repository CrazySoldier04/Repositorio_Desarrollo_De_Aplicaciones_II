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
                SqlServer();
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                PostgreSQL();
            }
            else if (cbMotor.SelectedIndex == 3)
            {
                MariaDB();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void MySQL()
        {
            cadena = "server=" + txtHost.Text + ";port=" + txtPuerto.Text + ";user=" + txtUsuario.Text + ";password=" + txtPass.Text;
            if (My.Conexion(cadena))
            {
                MessageBox.Show("Conectado", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                bases = My.ConsultaDT(cadena, "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA");
                txtConnectionString.Text = cadena;
                cbBases.DataSource = bases;
                cbBases.DisplayMember = "SCHEMA_NAME";
                cbBases.ValueMember = "SCHEMA_NAME";

                cbTablas.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al realizar la conexión", "Error al conectarse", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SqlServer()
        {
            MessageBox.Show("Ups", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void PostgreSQL()
        {
            MessageBox.Show("Ups", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void MariaDB()
        {
            MessageBox.Show("Ups", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void CargaDatos()
        {
            try
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
                    campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.columns where columns.table_NAME = '" + tb + "' AND TABLE_SCHEMA = '" + db + "';");
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
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Colores()
        {
            for (int i = 0; i < dgvBases.Rows.Count; i++)
            {
                if(dgvBases.Rows[i].Cells[7].Value.ToString() == "varchar")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Red;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "tinyint")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Salmon;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "int")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.SeaGreen;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "bigint")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.SkyBlue;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "datetime")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Tan;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "timestamp")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Tomato;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "double")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.YellowGreen;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "float")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Aquamarine;
                }
                else if (dgvBases.Rows[i].Cells[7].Value.ToString() == "text")
                {
                    dgvBases.Rows[i].Cells[7].Style.BackColor = Color.Beige;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CargaDatos();
            Colores();
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
            Close();
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