﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    public class PService : IParkeringGeneric<Parkering>
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
                // test
            }

            return list;
        }


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

        //public Parkering Create(Parkering newParkering)
        //{
        //    string sql = "insert into Parkering VALUES(@name, @v2, @v3)";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql, connection);
        //        cmd.Connection.Open();

        //        cmd.Parameters.AddWithValue("@name", newParkering.ParkeringsID);

        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows != 1)
        //        {
        //            throw new Exception("dab");
        //        }

        //        return newParkering;
        //    }
        //}

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
        /*
        public Parkering Read()
        {
            // Todo Tilføj Read til metode når det nødvendige til det, er på plads
        }
        */

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
