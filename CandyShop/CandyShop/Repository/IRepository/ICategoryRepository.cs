using CandyShop.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Repository.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
