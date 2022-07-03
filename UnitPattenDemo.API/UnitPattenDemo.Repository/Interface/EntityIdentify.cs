using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnitPattenDemo.Repository.Interface
{
    public abstract class EntityIdentify
    {
        [Key]
        public int Id { get; set; }
    }
}
