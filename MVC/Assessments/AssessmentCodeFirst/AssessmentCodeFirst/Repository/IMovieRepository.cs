using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCodeFirst.Repository
{
    public interface IMovieRepository<M> where M : class
    {
        IEnumerable<M> GetAll();
        M GetById(object Id);
        void Insert(M obj);
        void Update(M obj);
       
    }
}