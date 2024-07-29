using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string name { get; set; }
        public int stock { get; set; }
        public float price { get; set; }
        public ICollection<Order> Orders { get; set; }  
    }
}
