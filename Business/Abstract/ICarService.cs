﻿using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IServices<Car>
    {
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>> GetCarsByColorId(int colorId);
       IDataResult< List<CarDetailDto>> GetCarDetails();
        
    }
}
