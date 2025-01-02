using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AssessmentCodeFirst.Models;

namespace AssessmentCodeFirst.Repository
{
    public class ProductRepository<T> : IMovieRepository<T> where T : class
    {
        MovieContext db;
        DbSet<T> dbset;

        public ProductRepository()
        {
            db = new MovieContext();
            dbset = db.Set<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetById(object Id)
        {
            return dbset.Find(Id);
        }

        public void Insert(T obj)
        {
            dbset.Add(obj);

        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
    }
}