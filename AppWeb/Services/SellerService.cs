using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb.Models;
using AppWeb.Data;

namespace AppWeb.Services
{
    public class SellerService 
    {
        private readonly AppWebContext _context;

        public SellerService(AppWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
