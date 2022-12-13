using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }//THIS WILL BE THE PRIMARY KEY OF THE TABLE BY CONVENTION
        public string? Name { get; set; }

    }
}