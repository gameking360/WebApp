using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb.Data;
using AppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWeb.Services
{
    public class DepartmentService
    {
        private readonly AppWebContext _context;

        public DepartmentService(AppWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(p => p.Name).ToListAsync();
        }
    }
}
