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
            //Laver en liste.
            List<Tilmeld> list = new List<Tilmeld>();
            //Vi vælger alt data fra vores Arrangmentet table.
            string Sql = "Select * from Arrangementet";
            //Using statement der bruger vores connectionstring til at oprette forbindele til vores Azure Database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Der laves en query, hvori stringen "sql" bliver sat ind
                SqlCommand cmd = new SqlCommand(Sql, connection);
                //Vi åbner forbindelsen
                cmd.Connection.Open();
                //Sender "Commandteksten" til vores connection, og bygger en sqldatareader.
                SqlDataReader reader = cmd.ExecuteReader();
                //Vi kalder på vores Read, og tilføjer et nyt element(er) tl vores liste.
                while (reader.Read())
                {
                    Tilmeld a = ReadTilmelding(reader);
                    list.Add(a);
                }

            }
            //Vi returnere listen.
            return list;
            //Vi lukker ikke vores sql connection, eftersom, dette gøres automatisk. 
        }

        //Vi laver en ny liste der indeholer alle "Bruger_id", der er over 0.
        public List<int> GetAllId()
        {
            //Vi laver en ny liste
            List<int> list = new List<int>();
            //Vi vælger alle Bruger_id'er der er over 0 fra vores Arrangementet table.
            string sql = "select Bruger_id from Arrangementet WHERE Bruger_id > 0";
            //Using statement der bruger vores connectionstring til at oprette forbindele til vores Azure Database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Der laves en query, hvori stringen "sql" bliver sat ind
                SqlCommand cmd = new SqlCommand(sql, connection);
                //Vi åbner forbindelsen
                cmd.Connection.Open();
                //Sender "Commandteksten" til vores connection, og bygger en sqldatareader.
                SqlDataReader reader = cmd.ExecuteReader();

                //Vi kalder på vores Read, og tilføjer et nyt element(er) tl vores liste.
                while (reader.Read())
                {
                    int A = ReadId(reader);
                    list.Add(A);
                }
                //Vi returnerer vores liste.
                return list;
            }
            //Vi lukker ikke vores sql connection, eftersom, dette gøres automatisk. 
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

        //Denne metode læser et id, og returnerer et id(er)(int)
        private int ReadId(SqlDataReader reader)
        {
            int i = reader.GetInt32(0);
            return i;
        }
        
        //Denne metode opretter en ny arrangement bestilling.
        public int PostBrugerTilArrangement(Tilmeld postTilmeld)
        {
            //Vi inserter values i Arrangementet table.
            string sqlstring = $"Insert into Arrangementet VALUES( {postTilmeld.Bruger_id})";
            //Vi checker om brugeren allerede finde.
            var findesBrugeren = CheckOmBrugerFindes(postTilmeld.Bruger_id);
            //Vi bruger vores GetAll, og smider resultatet ind i en liste
            List<Tilmeld> Alist = GetAll();
            //Vi counter vores liste
            var hvorMangeKommer = Alist.Count();
            Console.WriteLine(hvorMangeKommer);
            //Vi laver en if statement, så hvis der er færre end 500 i listen, vil man kunne tilmelde sig, ellers returnerers der 0
            if(hvorMangeKommer < 500)
            {
                //If statement der siger at hvis brugeren ikke findes i systemet, kan man oprette sig, ellers returneres 0
                if (findesBrugeren == false)
                {
                    //Hvis alle krav overholdes, kører vi vores sql connection.
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //Der laves en query, hvori stringen "sql" bliver sat ind
                        SqlCommand command = new SqlCommand(sqlstring, connection);
                        //Vi åbner vores connection
                        command.Connection.Open();
                        //Vi executer vores nonquery,og returnerer antallet af rows affected.
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

             /*  public int deleteTilmelding(int Bestilling_id)
        {
            string sqlstring = $"delete from Arrangementet where Bestilling_id={Bestilling_id}";
            Tilmeld Delete = GetbyID(Bestilling_id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlstring, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                
                int rows = command.ExecuteNonQuery();
                


            }
            return 0;

        }
       
        */
        //En boolean der tjekker om brugeren allerede findes baseret på bruger_id.
        public Boolean CheckOmBrugerFindes(int Bruger_id)
        {
            //Vi selecter alt fra ARrangementet hvor bruger id = bruger id, så vi tjekker om brugeren findes.
            string sqlstring = $"Select * from Arrangementet WHERE Bruger_id={Bruger_id}";
            //Using statement der bruger vores connectionstring til at oprette forbindele til vores Azure Database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Vi åbner vores connection
                connection.Open();
                //Der laves en query, hvori stringen "sql" bliver sat ind
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                //If statement der siger at hvis rows affected ikke er 1, vil der returneres en false værdi.
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
    
