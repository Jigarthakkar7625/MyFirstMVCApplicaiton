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
    }
}