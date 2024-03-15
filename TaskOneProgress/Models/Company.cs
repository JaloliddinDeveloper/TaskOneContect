using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneProgress.Models
{
    internal class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
