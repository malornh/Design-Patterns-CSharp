using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetAll() => _products;

        public Product Get(int id) => _products[id];
        public void Add(Product product) => _products.Add(product);
        public void Update(Product product)
        {
            var existingProduct = _products[product.Id];
            if(existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }
        public void Delete(int id) => _products.RemoveAt(id);
    }
}
