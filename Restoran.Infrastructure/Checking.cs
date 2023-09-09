using Restoran.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Infrastructure
{
    public class Checking
    {
        public  Orders Insert()
        {
           
                Orders orders = new Orders();
                Console.WriteLine("insert Mealname");
                orders.mealname = Console.ReadLine();
                Console.WriteLine("insert Cost");
                orders.cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insert amount");
                orders.amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insert Personname");
                orders.person.Name = Console.ReadLine();
                Console.WriteLine("insert Id");
                orders.person.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert Phonenumber");
                orders.person.Phonenumber = Console.ReadLine();
               
                return orders;
            
            
        }
        public int DeleteID()
        {
            
                Console.WriteLine("Insert Id");
                int Id = Convert.ToInt32(Console.ReadLine());
                return Id;
            
        }
        public int UpdateId()
        {
            Console.WriteLine("Insert Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            return Id;
        }public int GetbyId()
        {
            Console.WriteLine("Insert Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            return Id;
        }

    }
}
