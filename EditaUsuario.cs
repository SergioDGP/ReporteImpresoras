using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteImpresoras
{
    public partial class EditaUsuario : Form
    {
        string strCorreo;
        string strNombre;
        string strPuesto;
        string strID_area;
        public Boolean validaActualizacion;


        public EditaUsuario(string correo, string nombre, string puesto, string id_area)
        {
            InitializeComponent();
            CargaDatos(correo, nombre, puesto, id_area);
        }

        private void btnSalirEdicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaDatos(string correo, string nombre, string puesto, string id_area)
        {
            strCorreo = correo;
            strNombre = nombre;
            strPuesto = puesto;
            strID_area = id_area;

            txtCorreo.Text = correo;
            txtNombre.Text = nombre;
            txtPuesto.Text = puesto;
            txtIDArea.Text = id_area;
        }

        private void checkCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCorreo.Checked)
            {
                txtCorreo.Enabled = true;
            }
            else
            {
                txtCorreo.Text = strCorreo;
                txtCorreo.Enabled = false;
            }
        }

        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Text = strNombre;
                txtNombre.Enabled = false;
            }
        }

        private void checkPuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPuesto.Checked)
            {
                txtPuesto.Enabled = true;
            }
            else
            {
                txtPuesto.Text = strPuesto;
                txtPuesto.Enabled = false;
            }
        }

        private void checkID_Area_CheckedChanged(object sender, EventArgs e)
        {
            if (checkID_Area.Checked)
            {
                txtIDArea.Enabled = true;
            }
            else
            {
                txtIDArea.Text = strID_area;
                txtIDArea.Enabled = false;
            }
        }

        private void btnEdicionConfirm_Click(object sender, EventArgs e)
        {
            validaActualizacion = false;
            if(txtCorreo.Text != strCorreo
                || txtNombre.Text != strNombre
                || txtPuesto.Text != strPuesto
                || txtIDArea.Text != strID_area)
            {
                var dialogResult = MessageBox.Show("Se actualizarán los datos del usuario: " + strCorreo, "Actualizar", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        AplicarActualizacion();
                        MessageBox.Show("Actualización aplicada correctamente");
                        validaActualizacion = true;
                        this.Close();   
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo aplicar la actualización, intentelo más tarde");
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe editar al menos actualizar uno de los campos para poder aplicar la actualización");
            }
        }

        private void AplicarActualizacion()
        {
            string strConection = "datasource=172.25.115.134 ; port=3306; username=root; password=n0m3l0; database=oma;";
            MySqlConnection sqlConexion = null;
            try
            {
                int ID_Area = Convert.ToInt32(txtIDArea.Text);
                sqlConexion = new MySqlConnection(strConection);

                sqlConexion.Open();
                Console.WriteLine("ÉXITO");
                string sqlCon = "UPDATE empleado SET Nombre = '" + txtNombre.Text + "', Puesto = '" + txtPuesto.Text +"', Area_idArea = "+ ID_Area +"  WHERE (Correo = '"+ strCorreo +"');";
                MySqlCommand com = new MySqlCommand(sqlCon, sqlConexion);// where Area_idarea = 3
                var apl = com.ExecuteNonQuery();
                sqlConexion.Close();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
        }
    }
}
