﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb.Data;
using AppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWeb.Services
{
    public class SalesRecordsService
    {
        private readonly AppWebContext _context;

        public SalesRecordsService(AppWebContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                    .Include(x => x.Seller)
                    .Include(x => x.Seller.Department)
                    .OrderByDescending(x => x.Date)
                    .ToListAsync();
        }
    }
}
