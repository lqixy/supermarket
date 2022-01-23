using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Other.Application.Contracts
{
    public class CategoryDto
    {

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte DelStatus { get; set; }
    }
}
