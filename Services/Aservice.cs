using Event_application.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    //Aservice (Arrangementservice) - Her knytter vi vores metoder til vores database.
    public class AService : ITilmeldingGeneric<Tilmeld>
    {
        //Connectionstring til vores database.
        private const string connectionString = @"Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        //Liste over alle tilmeldinger.
        public List<Tilmeld> GetAll()
        {
            List<Tilmeld> list = new List<Tilmeld>();
            string Sql = "Select * from Arrangementet";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Sql, connection);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tilmeld a = ReadTilmelding(reader);
                    list.Add(a);
                }

            }
            return list;
        }

        public List<int> GetAllId()
        {
            List<int> list = new List<int>();
            string sql = "select Bruger_id from Arrangementet WHERE Bruger_id>0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int a = ReadId(reader);
                    list.Add(a);
                }
                return list;
            }
        }


        public Tilmeld GetbyID(int Bruger_ID)
        {

            Tilmeld a = new Tilmeld();
            string queryString = $"select * from Arrangementet where Id = {Bruger_ID}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    a = ReadTilmelding(reader);
                    return a;

                }
            }

            return a;
        }

        //
        public Tilmeld Create(Tilmeld newTilmeld)
        {
            string sql = "insert into Arrangementet VALUES(@bestillings_ID, @bruger_ID)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@bestillings_ID", newTilmeld.Bestillings_ID);
                cmd.Parameters.AddWithValue("@bruger_ID", newTilmeld.Bruger_ID);
                int rows = cmd.ExecuteNonQuery();
                if (rows != 1)
                {
                    throw new Exception("Fejl");
                }
                return newTilmeld;
            }
        }
        private Tilmeld ReadTilmelding(SqlDataReader reader)
        {
            Tilmeld aa = new Tilmeld();
            aa.Bestillings_ID = reader.GetInt32(0);
            aa.Bruger_ID = reader.GetInt32(1);
            if (reader.IsDBNull(2))
            {
                aa.Bruger_ID = -1;

            }
            else
            {
                aa.Bruger_ID = reader.GetInt32(2);
            }
            return aa;
        }
        private int ReadId(SqlDataReader reader)
        {
            int i = reader.GetInt32(0);
            return i;
        }
        public Tilmeld Update(Tilmeld UpdateTilmeld)
        {
            string sqlstring = $"Update Arrangementet set Bestillings_ID={UpdateTilmeld.Bestillings_ID}, Bruger_ID={UpdateTilmeld.Bruger_ID}";
            Tilmeld Update = (UpdateTilmeld);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlstring, connection);
                command.Connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows != 1)
                {
                    throw new Exception("Fejl");
                }
            }
            return UpdateTilmeld;
        }
        public Tilmeld Delete(int bestillings_ID)
        {
            string sqlstring = $"delete from Arrangementet where Id={bestillings_ID}";
            Tilmeld Delete = GetbyID(bestillings_ID);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlstring, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                int rows = command.ExecuteNonQuery();
                if (rows != 1)
                {
                    throw new Exception("Fejl");
                }


            }
            return Delete;

        }
    }
}
    
