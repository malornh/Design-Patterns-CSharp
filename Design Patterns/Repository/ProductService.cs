using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Repository
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts() => _productRepository.GetAll();
        public Product GetProduct(int id) => _productRepository.Get(id);
        public void AddProduct (Product product) => _productRepository.Add(product);
        public void UpdateProduct (Product product) => _productRepository.Update(product);
        public void DeleteProduct(int id) => _productRepository.Delete(id);
    }
}
