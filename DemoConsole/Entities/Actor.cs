using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Entities
{
    internal class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool AcademyWiner { get; set; }
    }
}
