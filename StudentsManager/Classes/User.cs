using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager.Classes
{
    public class User
    {
        private int id;
        private string name;
        private string email;
        private bool isAdmin;

        public User()
        {
            id = 0;
            name = "";
            email = "";
            isAdmin = false;
        }

        public User(int _id, string _name, string _email, bool _isAdmin)
        {
            this.id = _id;
            this.name = _name;
            this.email = _email;
            this.isAdmin = _isAdmin;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
