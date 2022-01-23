using SupermarketManagement.Other.Application.Contracts;
using SupermarketManagement.Other.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Other.Application
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryRepository repository;

        public CategoryAppService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public CategoryDto Get(int id)
        {
            var entity = repository.Get(id);
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> Get(string name)
        {
            var entities = repository.Get(name);
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var entities = repository.GetAll();
            throw new NotImplementedException();
        }
    }
}
