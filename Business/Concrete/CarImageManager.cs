using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImagesDal _carImagesDal;

        public CarImageManager(ICarImagesDal carImagesDal)
        {
            _carImagesDal = carImagesDal;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage entity)
        {
            _carImagesDal.Add(entity);
            return new SuccessResult();
          
        }

        public IResult Delete(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImagesDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
