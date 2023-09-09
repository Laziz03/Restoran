using Restoran.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Application.Interfaces
{
    public interface IRepository
    { 
        public void Insert(Orders orders);
        public void Update(int Id);
        public void Delete(int Id);
        public void Getall();
        public void GetbyId(int id);
    }
}
