using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    public class PService:IParkeringGeneric<Parkering>
    {
        private const string connectionString = "Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private List<Parkering> _list;



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

        public Parkering GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        //public Parkering Create(Parkering newParkering)
        //{
        //    //{
        //    //    string sql = "insert into Parkering VALUES(@name, @v2, @v3)";

        //    //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    //    {
        //    //        SqlCommand cmd = new SqlCommand(sql, connection);
        //    //        cmd.Connection.Open();

        //    //        cmd.Parameters.AddWithValue("@name", newParkering.ParkeringsID);

        //    //        int rows = cmd.ExecuteNonQuery();

        //    //        if (rows != 1)
        //    //        {
        //    //            throw new Exception("dab");
        //    //        }

        //    //        return newParkering;
        //    //    }
        //    //}
        //}

        public Parkering Read()
        {
            throw new NotImplementedException();
        }

        public Parkering Update(Parkering updateParkering)
        {
            throw new NotImplementedException();
        }

        public Parkering Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

