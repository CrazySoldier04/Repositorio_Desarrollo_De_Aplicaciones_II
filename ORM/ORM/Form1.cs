using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using LibBaseDatosORM;
using System.Windows.Forms;

namespace ORM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        MySql libMySql;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            libMySql = new MySql("localhost", txtUser.Text, txtPwd.Text, txtPuerto.Text, txtDatabase.Text);
            txtConnectionString.Visible = true;
            txtConnectionString.Text = "host=localhost;uid=" + txtUser.Text + ";pwd=" + txtPwd.Text + ";port=" + txtPuerto.Text + ";database=" + txtDatabase.Text + ";";
            if (libMySql.OpenConnection())
            {
                MessageBox.Show("Conectado");
            }
            dgvDatos.DataSource = libMySql.Tables();
        }

        private void cbxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUser.Text = "root";
            txtPuerto.Text = "3306";
            txtDatabase.Text = "information_schema";
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos2.DataSource = libMySql.TableStructure(dgvDatos.CurrentCell.Value.ToString());
        }
    }
}
