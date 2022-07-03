using System;
using System.Collections.Generic;
using System.Text;
using UnitPattenDemo.Repository.Interface;

namespace UnitPattenDemo.Repository.Models
{
    public class UsersDetail: EntityIdentify
    {
        public int UserId { get; set; }
        public string  City { get; set; }
        public string  Country { get; set; }
    }
}
