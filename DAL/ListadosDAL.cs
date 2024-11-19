using System;
using ListadoPersonasENT;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DALEJ1
{
    public class ListadosDAL
    {
        /// <summary>
        /// Devuelve un listado de personas desde la base de datos en azure
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListadoCompletoPersonasDAL() {
            List<Persona> Personas = new List<Persona>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            Persona p = new Persona();

            try
            {
                ConexionSQL sqlconn = new ConexionSQL();
                SqlConnection conn = sqlconn.GetConnection();
                cmd.CommandText = "SELECT * FROM personas";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) { 
                        p = new Persona();
                        p.Id = (int)reader["ID"];
                        p.Nombre = (string)reader["Nombre"];
                        p.Apellido = (string)reader["Apellidos"];
                        p.FechaNac = (DateTime)reader["FechaNacimiento"];
                        Personas.Add(p);
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex) {
                throw ex;
            }
          

            return Personas;
        }
    }
}
