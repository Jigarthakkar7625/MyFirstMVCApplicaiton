using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplicaiton.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public int CustomerName { get; set; }

        [DisplayName("Customer Name : ")]
        [Required(ErrorMessage = "This CustomerNameString field is required  !!! Please add something")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "pleasse enter proper customer name")]
        [StringLength(10, ErrorMessage = "Max Length is 10")]
        public string CustomerNameString { get; set; }

        [DisplayName("Email : ")]
        [Required(ErrorMessage = "This Email field is required  !!! Please add something")]
        [EmailAddress(ErrorMessage = "Please enter valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This Age field is required  !!! Please add something")]
        [Range(1, 18, ErrorMessage = "Age should be in between 1 to 18")]
        public string Age { get; set; }

        public string Password { get; set; }

        public bool CheckBox { get; set; }
        public bool RadioButton { get; set; }
    }

    public class UserModel1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}