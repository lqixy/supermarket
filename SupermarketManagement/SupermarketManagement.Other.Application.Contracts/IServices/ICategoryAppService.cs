using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Other.Application.Contracts
{
    public interface ICategoryAppService
    {
        CategoryDto Get(int id);

        IEnumerable<CategoryDto> Get(string name);

        IEnumerable<CategoryDto> GetAll();
    }
}
