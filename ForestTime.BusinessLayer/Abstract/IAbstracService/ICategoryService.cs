﻿using ForestTime.BusinessLayer.Abstract.IGenericService;
using ForestTime.Entitylayer.Concrete;

namespace ForestTime.BusinessLayer.Abstract.IAbstracService
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<(string CategoryName, int BlogCount)>> GetCategoriesWithBlogCountsAsync();
    } 
}
