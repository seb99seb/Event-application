using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    /// <summary>
    /// En model klasse - Det her er vores PService (parkeringsservice). I denne klasse knyttes metoderne på vores database
    /// </summary>
    public class PService : IParkeringGeneric<Parkering>
    {
        /// <summary>
        /// Connectionstring, hvor vi kobler vores data til vores database
        /// </summary>
        private const string connectionString = "Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        /// <summary>
        /// En liste over alle vores parkeringspladser
        /// </summary>
        /// <returns>Vores liste</returns>
        public List<Parkering> GetAll()
        {
            List<Parkering> list = new List<Parkering>();
            string sql = "select * from Parkering";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Parkering p = ReadParkering(reader);
                    list.Add(p);
                }
                
            }

            return list;
        }
        public List<int> GetAllId()
        {
            List<int> list = new List<int>();
            string sql = "select Bruger_id from Parkering WHERE Bruger_id>0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int p = ReadId(reader);
                    list.Add(p);
                }
                return list;
            }
        }
        /// <summary>
        /// En metode hvor vi skaffer vores parkeringspladser ved brug af parkeringsID 
        /// </summary>
        /// <param name="id">Det er vores parkeringsid</param>
        /// <returns>Vores parkeringsplads</returns>
        public Parkering GetbyId(int id)
        {
            Parkering p = new Parkering();
            string queryString = $"select * from Parkering where Id = {id}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    p = ReadParkering(reader);
                    return p;
                }
            }

            return p;
        }


        /// <summary>
        /// En metode der bruges til at vise de ledige parkeringspladser der er tilbage
        /// </summary>
        /// <param name="reader">Den struktur der indeholder resultatstabellen</param>
        /// <returns>ledige parkeringspladser</returns>
        private Parkering ReadParkering(SqlDataReader reader)
        {
            Parkering pp = new Parkering();

            pp.ParkeringsID = reader.GetInt32(0);
            pp.ParkeringsNummer = reader.GetInt32(1);
            if (reader.IsDBNull(2))
            {
                pp.BrugerID = -1;
            }
            else
            {
                pp.BrugerID = reader.GetInt32(2);
            }

            return pp;
        }
        private int ReadId(SqlDataReader reader)
        {
            int i = reader.GetInt32(0);
            return i;
        }
        
        /// <summary>
        /// En metode, som bruges til at opdaterer vores parkeringspladser 
        /// </summary>
        /// <param name="updateParkering">Det er update til vores parkeringsplads</param>
        /// <returns>Vores updateparkering</returns>
        public Parkering Update(Parkering updateParkering)
        {
            string sqlString = $"Update Parkering set Parkering_id ={updateParkering.ParkeringsID}, Parkeringsplads_nummer = {updateParkering.ParkeringsNummer}, Bruger_id = {updateParkering.BrugerID} where Parkering_id = {updateParkering.ParkeringsID}";


            Parkering Update = (updateParkering);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlString, connection);
                command.Connection.Open();
                

                int rows = command.ExecuteNonQuery();

                if (rows != 1)
                {
                    throw new Exception("dab");
                }

            }

            return updateParkering;
        }

        /// <summary>
        /// En metode, som bruges til at slette vores parkeringspladser
        /// </summary>
        /// <param name="id">Vores Delete id</param>
        /// <returns>Delete</returns>
        public Parkering Delete(int id)
        {
            string sqlString = $"delete from Parkering Where Id = {id}";
            Parkering Delete = GetbyId(id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                int rows = command.ExecuteNonQuery();

                if (rows != 1)
                {
                    throw new Exception("dab");
                }


            }

            return Delete;

        }
    }


}

