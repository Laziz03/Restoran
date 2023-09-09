using Restoran.Domain.Models;
using Restoran.Infrastructure;
using Restoran.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Presenetattion
{
    public static class Managing
    {
       public static void start()
        {
            Checking checking = new Checking();
            while (true)
            {   Service service = new Service();
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete"); 
                Console.WriteLine("4.Getall");
                Console.WriteLine("5.getbyId");
                int choise=Convert.ToInt32(Console.ReadLine());
                switch(choise)
                {
                    case 1:service.Insert(checking.Insert());break;
                    case 2:service.Update(checking.UpdateId());break;
                    case 3:service.Delete(checking.DeleteID());break;
                    case 4:service.Getall();break;
                    case 5:service.GetbyId(checking.GetbyId());break;
                }
               


            }
        }
    }
}
