﻿using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public IResult Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }

    }
}