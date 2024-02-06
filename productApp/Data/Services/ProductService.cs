using productApp.Models;

namespace productApp.Data.Services
{
    public class ProductService : IProductsService
    {
        private readonly productAppContext _context;

        public ProductService(productAppContext context)
        {
            this._context = context;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            var result = _context.Product.ToList();
            return result;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id, Product newProduct)
        {
            throw new NotImplementedException();
        }
    }
}
