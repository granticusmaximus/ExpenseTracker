using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        [UIHint("Currency")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
        public ApplicationUser User { get; set; }
    }
}
