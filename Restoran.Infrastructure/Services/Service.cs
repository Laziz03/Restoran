using Restoran.Application.Interfaces;
using Restoran.Domain.Models;
using Restoran.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Infrastructure.Services
{
    public class Service : IService
    { private IRepository _Irepository;
        public Service()
        {
            _Irepository = new Repository.Repository();          
        }
        public void Delete(int Id)
        {
            _Irepository.Delete(Id);
        }

        public void Getall()
        {
            _Irepository.Getall();
        }

        public void GetbyId(int id)
        {
           _Irepository.GetbyId(id);
        }

        public void Insert(Orders orders)
        {
            _Irepository.Insert(orders);
        }

        public void Update(int Id)
        {
            _Irepository.Update(Id);
        }
    }
}
