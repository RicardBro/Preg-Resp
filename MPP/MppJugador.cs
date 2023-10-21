using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;

namespace MPP
{
    public class MppJugador:Mapper
    {
        public void AltaJugador(BeJugador jugador)
        {
            SqlCommand cmd = new SqlCommand("AtaJugador");
            try
            {
                cmd.Connection = conexion.Conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",jugador.Nombre);
                cmd.Parameters.AddWithValue("@apellido",jugador.Apellido);
                cmd.Parameters.AddWithValue("@usuario",jugador.Usuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Desconectar();
            }


        }
        
        public void BajaJugador(BeJugador jugador)
        {
            SqlCommand cmd = new SqlCommand("BajaJugador");
            
            try
            {
                cmd.Connection = conexion.Conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jugador.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Desconectar();
            }
        }

        public void ModificarJugador(BeJugador jugador)
        {
            SqlCommand cmd = new SqlCommand("ModificarJugador");
            try
            {
                cmd.Connection = conexion.Conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jugador.ID);
                cmd.Parameters.AddWithValue("@nombre", jugador.Nombre);
                cmd.Parameters.AddWithValue("@apellido", jugador.Apellido);
                cmd.Parameters.AddWithValue("@usuario", jugador.Usuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Desconectar();
            }


        }
        
        public List<BeJugador> ListarJugador()
        {
            SqlCommand cmd = new SqlCommand("ListarJugador");
            List<BeJugador> Jugadores = new List<BeJugador>();
            try
            {
                cmd.Connection = conexion.Conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BeJugador jugador = new BeJugador();
                    jugador.ID = Convert.ToInt32(dr["id"]);
                    jugador.Nombre = dr["nombre"].ToString();
                    jugador.Apellido = dr["apellido"].ToString();
                    jugador.Usuario = dr["usuario"].ToString();
                    Jugadores.Add(jugador);
                }
                return Jugadores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Desconectar();
            }
        }
            
        public void CargarPuntuacion(BeJugador jugador)
        {
            SqlCommand cmd = new SqlCommand("cargarPuntuacion");
            try
            {
                cmd.Connection = conexion.Conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jugador.ID);
                cmd.Parameters.AddWithValue("@puntos", jugador.Puntos);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Desconectar();
            }




        }
        
    }
}
