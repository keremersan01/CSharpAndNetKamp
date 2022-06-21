using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string TcNo { get; set; }

        public User(string name, string surname, string birthDate, string tcNo)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            TcNo = tcNo;
        }
    }
}
