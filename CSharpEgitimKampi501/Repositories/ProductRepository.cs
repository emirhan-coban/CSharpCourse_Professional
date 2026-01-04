using CSharpEgitimKampi501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task GetByProductIdAsync(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
