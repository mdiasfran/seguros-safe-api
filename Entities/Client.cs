using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seguros_safe_api.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CPF { get; set; }
        public DateTime DateBirth { get; set; }
    }
}