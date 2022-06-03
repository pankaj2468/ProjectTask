using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
       //[DataType(DataType.Date)]
        public DateTime DOJ { get; set; }
        //public DateTime DOR { get; set; }
        
        
    }

   
}
