using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDetails.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Maximum allowed characters upto 50")]
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Maximum allowed characters upto 50")]
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "Maximum allowed numbers upto 10")]
        [Required(ErrorMessage = "Phone is required")]
        public Nullable<int> Phone { get; set; }

        [StringLength(50, ErrorMessage = "Maximum allowed characters upto 50")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        //[Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

      
        [Required(ErrorMessage = "Marital Status is required")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [StringLength(50, ErrorMessage = "Maximum allowed characters upto 200")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Display(Name = "Gender")]
        public List<SelectListItem> Genders { get; set; }
    }
}