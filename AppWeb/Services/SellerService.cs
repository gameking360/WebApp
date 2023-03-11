﻿using System;
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
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);            
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
