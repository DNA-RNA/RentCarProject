using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IServices<T> where T: class
    {
       IDataResult<List<T>> GetAll();
       IResult Add(T entity);
       IResult Delete(T entity);
       IResult Update(T entity);
       IDataResult<T> GetById(int id);

    }
}
