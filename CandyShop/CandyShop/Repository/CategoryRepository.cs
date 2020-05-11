using CandyShop.Models;
using CandyShop.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category { CategoryId=1,CategoryName="Hardy Candy",CategoryDescription="Awesome and Delicious Hard Candy"},
            new Category { CategoryId = 2, CategoryName = "Chcocolate Candy", CategoryDescription = "Awesome and Delicious Chocolate Candy" },
            new Category { CategoryId = 3, CategoryName = "Fruit Candy", CategoryDescription = "Awesome and Delicious Fruit Candy" }
        };
        
        
        
    }
}
