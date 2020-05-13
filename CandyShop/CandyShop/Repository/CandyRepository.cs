using CandyShop.Models;
using CandyShop.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CandyShop.Repository
{
    public class CandyRepository : ICandyRepository
    {

        private readonly AppDbContext _appDbContext;
        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public IEnumerable<Candy> GetAllCandy()
        {
            return _appDbContext.Candies.Include(c => c.Category).ToList();
        }

        public IEnumerable<Candy> GetCandyOnSale()
        {
            return _appDbContext.Candies.Include(c => c.Category).Where(x => x.IsOnSale).ToList();
        }

        public Candy GetCandyById(int CandyId)
        {
            return _appDbContext.Candies.FirstOrDefault(x => x.CandyId == CandyId);
        }
    }
}
