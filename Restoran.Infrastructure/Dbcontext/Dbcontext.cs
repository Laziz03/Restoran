using Npgsql;
using Restoran.Application.Interfaces;
using Restoran.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Infrastructure.Dbcontext
{
    public class Dbcontext : IdbContext
    {
        public string Connectionstring = "Server=::1;Port=5432;Database=Hello;user id=postgres;password=123456";
            
        public int GetexecutenonQuery(string Command)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Connectionstring);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(Command, conn);
            int effectrows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectrows;

        }

        public NpgsqlDataReader GetexecuteQuery(string query)
        {
            using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(Connectionstring);
            npgsqlConnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, npgsqlConnection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
