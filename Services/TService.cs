using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.User;

namespace Event_application.Services
{
    public class TService
    {
        #region filler
        /*
        private Bruger _tbruger;

        private const string connectionString =
            @"Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Opret Tilmelding

        private Bruger tilmelding = new Bruger( "VIP_Bestilling, BrugerID");

        public int GetByVIP(int id)
        {
            String sql = "select * from VIP where VIP_Bestilling_ID = @id";


            // Opret Forbindelse 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //Åbner Forbinddelsen

                connection.Open();

                //Opretter sql query

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                //Altid ved select

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Bruger bruger = new Bruger();

                    return reader.GetInt32(1);
                }


            }

            throw new KeyNotFoundException();
        }
        */
#endregion
        private const string connectionString = "Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private List<Parkering> _list;

        public List<VIP> GetAll()
        {
            List<VIP> list = new List<VIP>();
            string sql = "select * from VIP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VIP p = ReadVIP(reader);
                    list.Add(p);
                }
            }
            return list;
        }


        public VIP GetbyId(int id)
        {
            VIP p = new VIP();
            string queryString = $"select * from VIP where Id = {id}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    p = ReadVIP(reader);
                    return p;
                }
            }

            return p;
        }

        private VIP ReadVIP(SqlDataReader reader)
        {
            VIP pp = new VIP();

            pp.VIPID = reader.GetInt32(0);
            if (reader.IsDBNull(1))
            {
                pp.BrugerID = -1;
            }
            else
            {
                pp.BrugerID = reader.GetInt32(1);
            }

            return pp;
        }
        /*
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
        */
        /*
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
        */
        public void Create(int bruger_id)
        {
            string queryString = $"INSERT INTO VIP (Bruger_id) VALUES ('{bruger_id}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Connection.Open();

                command.ExecuteReader();
            }
        }
    }
}