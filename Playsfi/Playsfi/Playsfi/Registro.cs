using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Playsfi
{
    public partial class Registro : Form
    {
        //cadena de conexión
        string cadena = "Data Source=C06PC29\\SQLEXPRESS;Initial Catalog=playsfi;Integrated Security=True";
        //abrir conexión
        SqlConnection conex;

        public Registro()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            conex = new SqlConnection(cadena);
            conex.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conex;

            //el id, la variable se inicia con el número siguiente al último de la bd
            string query = "SELECT ISNULL(MAX(id_user),0) FROM Usuario";
            comando.CommandText = query;

            // Obtener el último ID de la base de datos
            // Incrementar el ID para obtener el siguiente
            int nextId = Convert.ToInt32(comando.ExecuteScalar())+1;

            //almacenar datos
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            int? edad = int.Parse(txtEdad.Text);
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(dni) || edad == null)
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                //comando de ejecución
                string insert = "INSERT INTO Usuario VALUES (" + nextId + ", '" + nombre + "', '" + apellidos + "', " + edad + ", '" + dni + "')";
                comando.CommandText = insert;
                int filasAfectadas = comando.ExecuteNonQuery();

                //mensaje de registrado correctamente
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Inserción realizada correctamente", "Acción:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControlLibros cl = new ControlLibros(nextId);
                    cl.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Inserción no realizada correctamente", "Acción:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conex.Close();
            }

            
        }
    }
}
