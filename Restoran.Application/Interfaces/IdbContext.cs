using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Application.Interfaces
{
    public  interface IdbContext
    {
       public int GetexecutenonQuery(string Command);
        public NpgsqlDataReader GetexecuteQuery(string query);
    }
}
