using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Shared.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public ApplicationUser User { get; set; }
    }
}
