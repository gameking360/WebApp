using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthday, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthday = birthday;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSale(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSale(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(p => p.Date >= initial && p.Date <= final).Sum(p => p.Amount);
        } 
    }
}
