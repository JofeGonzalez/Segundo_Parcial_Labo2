using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public static class Sql
    {
        static SqlConnection cnx;
        static Sql()
        {
            cnx = new SqlConnection("server=DESKTOP-OG6OM47\\SQLEXPRESS; database=BD2Parcial; integrated security = true");
        }
        public static List<Producto> GetProductos()
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                SqlCommand comando = new SqlCommand("Select * from Producto", cnx);
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    productos.Add(new Producto(int.Parse(datos["IdProductos"].ToString()), (datos["NombreProducto"]).ToString()));
                }
                return productos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        public static List<Cliente> GetClientes()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                SqlCommand comando = new SqlCommand("Select * from Clientes", cnx);
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    clientes.Add(new Cliente((datos["NombreCliente"].ToString()), int.Parse(datos["DniCliente"].ToString()), (int.Parse(datos["IdCliente"].ToString())), datos["DireccionCliente"].ToString()));
                }
                return clientes;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        public static void AgregarVenta(int idProducto, int idCliente, modoEntrega modoEntrega)
        {
            try
            {
                string query = "insert into Ventas (idProducto, idCliente, modoEntrega) values (@idProducto, @idCliente, @modoEntrega)";
                cnx.Open();
                SqlCommand comando = new SqlCommand(query, cnx);
                comando.Parameters.AddWithValue("@idProducto", idProducto);
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Parameters.AddWithValue("@modoEntrega", modoEntrega);
                comando.ExecuteNonQuery();
                if (modoEntrega.ToString() == "delivery")
                {
                    Cliente cliente = GetDatosCliente(idCliente);
                    GuardarPedidoDelivery(cliente);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        public static int GetIdCliente(string cliente)
        {
            try
            {
                SqlCommand comandoCliente = new SqlCommand($"Select idCliente from Clientes where NombreCliente = '{cliente}'", cnx);
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }
                SqlDataReader idCliente = comandoCliente.ExecuteReader();
                while (idCliente.Read())
                {
                    return int.Parse(idCliente["idCliente"].ToString());
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }

        }
        public static Cliente GetDatosCliente(int id)
        {
            try
            {
                Cliente cliente = new Cliente();
                SqlCommand comandoCliente = new SqlCommand($"select * from Clientes where IdCliente = '{id}'", cnx);
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }
                SqlDataReader datosCliente = comandoCliente.ExecuteReader();
                while (datosCliente.Read())
                {
                    cliente = new Cliente((datosCliente["NombreCliente"].ToString()), int.Parse(datosCliente["DniCliente"].ToString()), (int.Parse(datosCliente["IdCliente"].ToString())), datosCliente["DireccionCliente"].ToString());
                }
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }
        }
        public static int GetIdProducto(string producto)
        {
            try
            {
                SqlCommand comandoProducto = new SqlCommand($"Select idProductos from Producto where NombreProducto = '{producto}'", cnx);
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }
                SqlDataReader idProducto = comandoProducto.ExecuteReader();
                while (idProducto.Read())
                {
                    return int.Parse(idProducto["idProductos"].ToString());
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }

        }
        public static void AgregarCliente(string nombre, int dni, string direccion)
        {
            string query = "insert into Clientes (NombreCliente, DniCliente, DireccionCliente) values (@nombre, @dni, @direccion)";
            cnx.Open();
            SqlCommand comando = new SqlCommand(query, cnx);
            comando.Parameters.AddWithValue("@nombre", Persona.ValidarNombreApellido(nombre));
            comando.Parameters.AddWithValue("@dni", Persona.ValidarDni(dni));
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();

        }
        public static void ModificarCliente(string nombre, int dni, string direccion, int idCliente)
        {
            string query = "update Clientes set NombreCliente = @nombre, DniCliente = @dni, DireccionCliente = @direccion where idCliente=@id";
            cnx.Open();
            SqlCommand comando = new SqlCommand(query, cnx);
            comando.Parameters.AddWithValue("@nombre", Persona.ValidarNombreApellido(nombre));
            comando.Parameters.AddWithValue("@dni", Persona.ValidarDni(dni));
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@id", idCliente);
            comando.ExecuteNonQuery();
            cnx.Close();
        }
        public static void EliminarCliente(int id)
        {
            string query = "delete from Clientes where idCliente = @id";
            cnx.Open();
            SqlCommand comando = new SqlCommand(query, cnx);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
        }
        public static List<Venta> LeerPedidosXml()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\xml.xml";
            Xml<List<Venta>> xml = new Xml<List<Venta>>();
            List<Venta> ventas = new List<Venta>();
            xml.Leer(path, out ventas);
            return ventas;
        }
        public static void GuardarPedidoDelivery(Cliente cliente)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\deliverys.txt";
            string venta = $"{cliente.Nombre} , {cliente.DNI} , {cliente.DireccionCliente}";
            Texto texto = new Texto();
            texto.Guardar(path, venta);
        }

    }
}