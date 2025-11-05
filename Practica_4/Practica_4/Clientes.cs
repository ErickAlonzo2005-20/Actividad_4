using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_4
{
    public partial class Clientes : Form
    {

        private const string connectionString = @"Data Source=DESKTOP-H0RUUE2;Initial Catalog=Practica4;Integrated Security=True;";

        public Clientes()
        {
            InitializeComponent();
        }


        private void cargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ajustamos la consulta para la tabla de clientes
                    string queryClientes = "SELECT ClienteID, NombreCompleto, Telefono, CorreoElectronico, Direccion FROM Clientes;";

                    using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Ajustamos el nombre del DataGridView
                            dgClientes.DataSource = dt;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de clientes: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // La conexión se cierra automáticamente gracias al 'using'
        }

       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDActualizar.Text) || !int.TryParse(txtIDActualizar.Text, out int clienteID))
            {
                MessageBox.Show("Debe introducir un ID de cliente numérico y válido para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de los nuevos datos
            if (string.IsNullOrWhiteSpace(txtNombreActualizado.Text) ||
                string.IsNullOrWhiteSpace(textTelefonoActualizado.Text) ||
                string.IsNullOrWhiteSpace(textCorreoElectronicoActualizado.Text) ||
                string.IsNullOrWhiteSpace(textDireccionActualizado.Text))
            {
                MessageBox.Show("Todos los campos para actualizar son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-H0RUUE2;Initial Catalog=Practica4;Integrated Security=True;";


            // Consulta con parámetros
            string queryActualizarClientes = @"UPDATE Clientes 
                                  SET NombreCompleto = @Nombre, 
                                      Telefono = @Telefono, 
                                      CorreoElectronico = @Correo, 
                                      Direccion = @Direccion 
                                  WHERE ClienteID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryActualizarClientes, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreActualizado.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textTelefonoActualizado.Text);
                    cmd.Parameters.AddWithValue("@Correo", textCorreoElectronicoActualizado.Text);
                    cmd.Parameters.AddWithValue("@Direccion", textDireccionActualizado.Text);
                    cmd.Parameters.AddWithValue("@ID", clienteID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" Cliente actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show(" No se encontró un cliente con ese ID para actualizar.", "Información");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(" Error al actualizar cliente: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.cargarDatos();
        }

       
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out _))
            {
                MessageBox.Show("Debe introducir un ID de cliente numérico y válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-H0RUUE2;Initial Catalog=Practica4;Integrated Security=True;";

            string queryEliminarCliente = @"DELETE FROM Clientes WHERE ClienteID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryEliminarCliente, connection))
                {
                    // AÑADIMOS PARÁMETROS: Protegemos el ID contra Inyección SQL
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se ha eliminado el cliente de la base de datos. ");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un cliente con ese ID.", "Información");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.cargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(textTelefono.Text) ||
               string.IsNullOrWhiteSpace(textCorreoelec.Text) ||
               string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                MessageBox.Show("Todos los campos (Nombre, Teléfono, Correo y Dirección) son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = @"Data Source=DESKTOP-H0RUUE2;Initial Catalog=Practica4;Integrated Security=True;";
            ;

            // Usamos parámetros SQL para construir la consulta de forma segura.
            string queryInsertarClientes = @"INSERT INTO Clientes (NombreCompleto, Telefono, CorreoElectronico, Direccion)
                                            VALUES (@Nombre, @Telefono, @Correo, @Direccion)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryInsertarClientes, connection))
                {
                    //AÑADIMOS PARÁMETROS: Esto es lo más importante para corregir el error de inyección SQL 
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                    cmd.Parameters.AddWithValue("@Correo", textCorreoelec.Text);
                    cmd.Parameters.AddWithValue("@Direccion", textDireccion.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se ha insertado el cliente en la base de datos. ✔️");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al insertar cliente: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.cargarDatos();
        }




        private void Clientes_Load(object sender, EventArgs e)
        {
            // Solo cargamos los datos de los clientes al iniciar el formulario
            this.cargarDatos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            // Validación del ID
            if (string.IsNullOrWhiteSpace(txtIDActualizar.Text) || !int.TryParse(txtIDActualizar.Text, out int clienteID))
            {
                MessageBox.Show("Debe introducir un ID de cliente numérico y válido para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de los nuevos datos
            if (string.IsNullOrWhiteSpace(txtNombreActualizado.Text) ||
                string.IsNullOrWhiteSpace(textTelefonoActualizado.Text) ||
                string.IsNullOrWhiteSpace(textCorreoElectronicoActualizado.Text) ||
                string.IsNullOrWhiteSpace(textDireccionActualizado.Text))
            {
                MessageBox.Show("Todos los campos para actualizar son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-H0RUUE2;Initial Catalog=Practica4;Integrated Security=True;";


            // Consulta con parámetros
            string queryActualizarClientes = @"UPDATE Clientes 
                                  SET NombreCompleto = @Nombre, 
                                      Telefono = @Telefono, 
                                      CorreoElectronico = @Correo, 
                                      Direccion = @Direccion 
                                  WHERE ClienteID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryActualizarClientes, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreActualizado.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textTelefonoActualizado.Text);
                    cmd.Parameters.AddWithValue("@Correo", textCorreoElectronicoActualizado.Text);
                    cmd.Parameters.AddWithValue("@Direccion", textDireccionActualizado.Text);
                    cmd.Parameters.AddWithValue("@ID", clienteID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" Cliente actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show(" No se encontró un cliente con ese ID para actualizar.", "Información");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(" Error al actualizar cliente: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.cargarDatos();

        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ajustamos la consulta para la tabla de clientes
                    string queryClientes = "SELECT ClienteID, NombreCompleto, Telefono, CorreoElectronico, Direccion FROM Clientes;";

                    using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Ajustamos el nombre del DataGridView
                            dgClientes.DataSource = dt;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de clientes: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // La conexión se cierra automáticamente gracias al 'using'
        }
    }
}
