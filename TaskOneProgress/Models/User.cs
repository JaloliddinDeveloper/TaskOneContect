using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneProgress.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Job {  get; set; }
        public int ComIdFK { get; set; }
        public Company Company { get; set; }
    }
}
