﻿using productApp.Models;

namespace productApp.Data.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        Product Update(int id, Product newProduct);
        void Delete(int id);

    }
}
