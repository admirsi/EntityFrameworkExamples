using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoExistingDbMVC.Models
{
    public partial class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public bool AcademyWiner { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
    }
}