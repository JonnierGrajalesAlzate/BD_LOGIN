using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using PROCESO_CRUD.Modelo;

namespace PROCESO_CRUD.Logica
{  
    public class PersonaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static PersonaLogica instancia = null; 
        private PersonaLogica() { } 
        public static PersonaLogica Instacia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PersonaLogica();
                }
                return instancia;
            }
        } 
        public bool Guardar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                try
                {
                    conexion.Open();
                    string query = "insert into Persona (nombre, clave) values (@nombre, @clave)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.pcNombrePersona));
                    cmd.Parameters.Add(new SQLiteParameter("@clave", obj.pnClavePersona));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"Error al guardar persona: {ex.Message}");
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Actualizar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                try
                {
                    conexion.Open(); 
                    string query = "update Persona set nombre=@nombre, clave=@clave where id=@pnIdPersona";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion); 
                    cmd.Parameters.Add(new SQLiteParameter("@pnIdPersona", obj.pnIdPersona));
                    cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.pcNombrePersona));
                    cmd.Parameters.Add(new SQLiteParameter("@clave", obj.pnClavePersona));
                    cmd.CommandType = System.Data.CommandType.Text; 
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar persona: {ex.Message}");
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Eliminar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                try
                {
                    conexion.Open();
                    string query = "delete from Persona where id=@pnIdPersona";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnIdPersona", obj.pnIdPersona)); 
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar persona: {ex.Message}");
                    respuesta = false;
                }
            }

            return respuesta;
        }
        public List<Persona> Listar()
        {
            List<Persona> oLista = new List<Persona>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id, nombre, clave FROM Persona";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Persona persona = new Persona(); 
                            if (dr["id"] != DBNull.Value && int.TryParse(dr["id"].ToString(), out int lnId))
                            {
                                persona.pnIdPersona = lnId;
                            }
                            else
                            {
                                persona.pnIdPersona = 0;  
                            }
                             
                            persona.pcNombrePersona = dr["nombre"] != DBNull.Value ? dr["nombre"].ToString() : string.Empty;
                             
                            if (dr["clave"] != DBNull.Value && int.TryParse(dr["clave"].ToString(), out int lnClave))
                            {
                                persona.pnClavePersona = lnClave;
                            } 

                            oLista.Add(persona);
                        }
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"Error al listar personas: {ex.Message}");
                }
            }

            return oLista;
        }
    }
}
