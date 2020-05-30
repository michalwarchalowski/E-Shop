using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Repository.IRepository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
