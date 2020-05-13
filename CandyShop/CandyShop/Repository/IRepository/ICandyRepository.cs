using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Repository.IRepository
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy();
        IEnumerable<Candy> GetCandyOnSale();
        Candy GetCandyById(int CandyId);
    }
}
