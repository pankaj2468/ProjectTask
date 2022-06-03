using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTask.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Salary { get; set; }
        public string Department { get; set; }
        public DateTime DOJ { get; set; }
        public DateTime DOR { get; set; }

        public List<Employee> SearchResults { get; internal set; }

        public SelectList TypeOptions { get; set; }

        // Selected search options
        [Required]
        public string SearchType { get; set; }
        [Required]
        public string SearchText { get; set; }
        public string CurrentFilter { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

    }
}
