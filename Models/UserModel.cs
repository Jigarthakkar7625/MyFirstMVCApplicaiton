using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplicaiton.Models
{
    public class UserModel
    {
        public int CustomerID   { get; set; }
        public int CustomerName { get; set; }

        public string CustomerNameString { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public int ParentUserID { get; set; }
        public Nullable<int> Gender { get; set; }
    }
}