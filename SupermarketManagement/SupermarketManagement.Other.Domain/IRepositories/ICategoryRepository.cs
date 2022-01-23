using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Other.Domain
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        IEnumerable<Category> GetAll();

        IEnumerable<Category> Get(string name);
    }
}
