﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCRUDDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string WorkingMode { get; set; }
        public bool IsActive { get; set; }
    }
}