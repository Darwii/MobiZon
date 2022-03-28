using DomainLayer;
using Repository;
using System;
using System.Collections.Generic;

namespace BusinessObjectLayer
{
    public class ProductCatalog : IProductCatalog
    {
        ProductDbContext _context;
        IRepositoryOperations<Product> _repo;
        public ProductCatalog(ProductDbContext context )
        {
            _context = context;
            _repo = new RepositoryOperations<Product>(_context); 
        }
        public void AddProduct(Product entity)
        {
            try
            {
                _repo.Add(entity);
                _repo.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void DeleteProduct(Product entity)
        {
            try
            {
                _repo.Delete(entity);
                _repo.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void EditProduct(Product entity)
        {
            try
            {
                _repo.Update(entity);
                _repo.Save();
            }
            catch( Exception ex)
            {
                throw ex;
            }
            
        }

        public Product GetById(int id)
        {
            try
            {
                return _repo.GetById(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<Product> GetProduct()
        {
            try
            {
                return _repo.Get();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
