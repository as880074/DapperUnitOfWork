using System;
using System.Collections.Generic;
using System.Text;
using UnitPattenDemo.Repository.Interface;

namespace UnitPattenDemo.Repository.Models
{
    public class Users: EntityIdentify
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
