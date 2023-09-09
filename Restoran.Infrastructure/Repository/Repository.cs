using Dapper;
using Npgsql;
using Restoran.Application.Interfaces;
using Restoran.Domain.Models;

namespace Restoran.Infrastructure.Repository
{
    public class Repository : IRepository
    {
        public string Connectionstring = "Server=::1;Port=5432;Database=functions_home;user id=postgres;password=postgres";
        private readonly IdbContext _idbContext;
        public Repository()
        {
            _idbContext = new Dbcontext.Dbcontext();
        }

        public void Delete(int Id)
        {
            try
            { 
                string Command = $"delete from ordersofrestoran where id={Id}";
                int effectrows = _idbContext.GetexecutenonQuery(Command);
                if (effectrows > 0)
                {  
                    Console.WriteLine("successfully added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("someting went worng");
            }
        }

        public void Getall() {
           
           string query = "select * from ordersofrestoran";
            using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(Connectionstring);
            npgsqlConnection.Open();
            List<Orders> orders = npgsqlConnection.Query<Orders>(query).ToList();
            //NpgsqlCommand cmd = new NpgsqlCommand(query, npgsqlConnection);
            //NpgsqlDataReader reader = cmd.ExecuteReader();
            //while(reader.Read())
            //{
            //    orders.Add(new Orders()
            //    {
            //        amount = (int)reader["amount"],
            //        cost = (int)reader["cost"],
            //        mealname = (string)reader["mealname"],
            //        person=new Person()
            //        {
            //            Name = (string)reader["personname"],
            //            Id = (int)reader["id"],
            //            Phonenumber = (string)reader["phonenumber"]
            //        }
            //    });
            //}

            foreach (Orders o in orders)
            {
                Console.WriteLine("amount:" + o.amount);
                Console.WriteLine("mealname:" + o.mealname);
                Console.WriteLine("cost:" + o.cost);
                Console.WriteLine("Personname:" + o.person.Name);
                Console.WriteLine("Phonenumber:" + o.person.Phonenumber);
                Console.WriteLine("Person Id:" + o.person.Id);
            }

            npgsqlConnection.Close();   

        }

        public void GetbyId(int id)
        {
            string Query = $"select * from ordersofrestoran where id={id}";
            using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(Connectionstring);
            npgsqlConnection.Open();
            NpgsqlCommand cmd=new NpgsqlCommand(Query,npgsqlConnection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Orders> orders = new List<Orders>();
           while (reader.Read()) 
            {
                orders.Add(new()
                {

                    amount = (int)reader["amount"],
                    cost = (int)reader["cost"],
                    mealname = (string)reader["mealname"],
                    person = new Person()
                    {
                        Name = (string)reader["personname"],
                        Id = (int)reader["id"],
                        Phonenumber = (string)reader["phonenumber"]
                    }
                }
             );
            }
            foreach (Orders o in orders)
            {
                Console.WriteLine("amount:" + o.amount);
                Console.WriteLine("mealname:" + o.mealname);
                Console.WriteLine("cost:" + o.cost);
                Console.WriteLine("Personname:" + o.person.Name);
                Console.WriteLine("Phonenumber:" + o.person.Phonenumber);
                Console.WriteLine("Person Id:" + o.person.Id);
            }
        }

        public void Insert(Orders orders)
        {

            try
            {
                string Command = $"insert into ordersofrestoran(amount,cost,mealname,personname,id,phonenumber) values({orders.amount},{orders.cost},'{orders.mealname}','{orders.person.Name}',{orders.person.Id},'{orders.person.Phonenumber}')";
                int effectrows = _idbContext.GetexecutenonQuery(Command);
                if (effectrows > 0)
                {
                    Console.WriteLine("succesfully added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("someting went wrong in inserting");
            }
        }

        public void Update(int Id)
        {
            Console.WriteLine("insert new amount");
            int newamount = Convert.ToInt32(Console.ReadLine());
            string Command = $"Update ordersofrestoran set amount={newamount} where id={Id}";
            int effectrows = _idbContext.GetexecutenonQuery(Command);
            if( effectrows>0)
            {
                Console.WriteLine("succesfilly updated");
            }
        }
    }
}
