﻿using Company.Core.DataAccess.EntityFramework;
using Company.DataAccess.Abstract;
using Company.DataAccess.Concrete.EntityFramework.Contexts;
using Company.Entities.Concrete;

namespace Company.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
