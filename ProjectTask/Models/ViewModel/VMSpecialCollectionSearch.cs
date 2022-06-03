using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTask.Models.ViewModel
{
    public class VMSpecialCollectionSearch
    {
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
