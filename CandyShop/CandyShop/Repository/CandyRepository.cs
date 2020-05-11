using CandyShop.Models;
using CandyShop.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Repository
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();


        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy{CandyId=1,Name="Assorted hard Candy",Price=4.95M,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
            "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make " +
            "a type specimen book. It has survived not only five centuries, but also the leap into electronic",Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/220px-HardCandy.jpg",
        IsOnStock=true,IsOnSale=false,ImageThumnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/220px-HardCandy.jpg"},

            new Candy{CandyId=2,Name="Assorted Chocolate Candy",Price=4.95M,Description="setting, remaining essentially unchanged. It was popularised in the 1960s with the release" +
        " of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
        Category=_categoryRepository.GetAllCategories.ToList()[1],ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg",
        IsOnStock=true,IsOnSale=false,ImageThumnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg"},

               new Candy{CandyId=3,Name="Assorted Fruit Candy",Price=4.95M,Description="setting, remaining essentially unchanged. It was popularised in the 1960s with the release" +
        " of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
        Category=_categoryRepository.GetAllCategories.ToList()[2],ImageUrl="https://upload.wikimedia.org/wikipedia/commons/1/10/Welch%27s_Fruit_Snacks_%284239096810%29.jpg",
        IsOnStock=true,IsOnSale=false,ImageThumnailUrl="https://upload.wikimedia.org/wikipedia/commons/1/10/Welch%27s_Fruit_Snacks_%284239096810%29.jpg"}
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int CandyId)
        {
            return GetAllCandy.FirstOrDefault(x => x.CandyId == CandyId);
        }
    }
}
