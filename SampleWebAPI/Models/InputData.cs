using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAPI.Models
{
    public class InputData
    {
        [Required(ErrorMessage ="Name is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [RegularExpression(@"^(?:\(\d{3}\)|\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Please enter it in xxx-xxx-xxxx")]
        public string Phone { get; set; }
        public string Notes { get; set; }
    }
}
