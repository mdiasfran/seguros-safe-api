using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seguros_safe_api.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}