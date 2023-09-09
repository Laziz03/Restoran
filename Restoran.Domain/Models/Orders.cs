using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Domain.Models
{
    public class Orders
    {
        public string mealname { get; set; }
        public int cost { get; set; }
        public int amount { get; set; }
        public Person person { get; set; }=new Person();
    }
}
