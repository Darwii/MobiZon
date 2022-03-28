using DomainLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RepositoryOperations<T> : IRepositoryOperations<T> where T:class
    {
        DbContext Context;
        readonly DbSet<T> dbSet;
        IEnumerable<T> entities;
        T entity;
       
        public RepositoryOperations(DbContext product)
        {
            Context = product;
            dbSet = Context.Set<T>();
           
        }
        public void Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<T> Get()
        {
            try
            {
                entities = dbSet.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return entities;
        }

        public T GetById(int Id)
        {
            try
            {
                entity = dbSet.Find(Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Update(T entity)
        {
            try
            {
                dbSet.Update(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
