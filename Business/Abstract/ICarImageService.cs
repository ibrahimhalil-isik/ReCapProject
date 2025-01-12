﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int carImageId);

        IResult Add(CarImage carImage, IFormFile formFile);
        IResult Update(CarImage carImage, IFormFile formFile);
        IResult Delete(CarImage carImage);
        
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IResult TransactionalOperation(CarImage carImage, IFormFile file);
    }
}
