using SupermarketManagement.Common;
using SupermarketManagement.Other.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Other.Repository.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private IEnumerable<Category> categories = Enumerable.Range(0, 1000)
            .Select(x => new Category(x, StringExtension.RandChina(4), StringExtension.RandChina(20)));

        public Category Get(int id)
        {
            return categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public IEnumerable<Category> Get(string name)
        {
            return categories.Where(x => x.Name.Contains(name));
        }

        public IEnumerable<Category> GetAll()
        {
            return categories;
        }
    }
}
