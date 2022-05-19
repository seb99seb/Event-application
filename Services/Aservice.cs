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
            string sql = "select Bruger_id from Arrangementet WHERE Bruger_id > 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int A = ReadId(reader);
                    list.Add(A);
                }
                return list;
            }
        }


        public Tilmeld GetbyID(int id)
        {

            Tilmeld a = new Tilmeld();
            string queryString = $"select * from Arrangementet where Id = {id}";
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

    
        private Tilmeld ReadTilmelding(SqlDataReader reader)
        {
            {
                Tilmeld tt = new Tilmeld();
                tt.Bruger_id = reader.GetInt32(0);
                tt.Bestilling_id = reader.GetInt32(1);

                
                

                return tt;
            }
        }


        private int ReadId(SqlDataReader reader)
        {
            int i = reader.GetInt32(0);
            return i;
        }

       
        
        public int PostBrugerTilArrangement(Tilmeld postTilmeld)
        {
            string sqlstring = $"Insert into Arrangementet VALUES( {postTilmeld.Bruger_id})";
            var findesBrugeren = CheckOmBrugerFindes(postTilmeld.Bruger_id);
            List<Tilmeld> Alist = GetAll();
            var hvorMangeKommer = Alist.Count();
            Console.WriteLine(hvorMangeKommer);
            if(hvorMangeKommer <= 500)
            {
                if (findesBrugeren == false)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(sqlstring, connection);
                        command.Connection.Open();
                        int rows = command.ExecuteNonQuery();
                        Console.WriteLine(rows);
                        return rows;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else {
                return 0;
            }
            
        }

        
        public int deleteTilmelding(int Bestilling_id)
        {
            string sqlstring = $"delete from Arrangementet where Id={Bestilling_id}";
            Tilmeld Delete = GetbyID(Bestilling_id);
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
            return 0;

        }

        public Boolean CheckOmBrugerFindes(int Bruger_id)
        {
            string sqlstring = $"Select * from Arrangementet WHERE Bruger_id={Bruger_id}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                if( rowsAffected != 1)
                {
                    return false;
                    connection.Close();
                }
                else
                {
                    return true;
                    connection.Close();
                }
            }
        
        }
    }
}
    
