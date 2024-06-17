using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin : Person
    {
        public Admin() { }

        public Admin(string name, UserRole role, string phoneNumber, string email, string password) : base(name, role, phoneNumber, email, password) { }

        public Admin(int id, string name, UserRole role, string phoneNumber, string email, string password) : base(id, name, role, phoneNumber, email, password) { }
    }
}
