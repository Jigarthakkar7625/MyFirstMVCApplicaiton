﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplicaiton.Models
{
    public class CustomerModel
    {
        public int CustomerID   { get; set; }
        public int CustomerName { get; set; }

        public string CustomerNameString { get; set; }
        public string Password { get; set; }

        public bool CheckBox { get; set; }
        public bool RadioButton { get; set; }
    }
}