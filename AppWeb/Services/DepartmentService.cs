using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb.Data;
using AppWeb.Models;

namespace AppWeb.Services
{
    public class DepartmentService
    {
        private readonly AppWebContext _context;

        public DepartmentService(AppWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(p => p.Name).ToList();
        }
    }
}
