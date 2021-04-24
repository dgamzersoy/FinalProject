using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IResult Add(Basket basket);
    }
}
