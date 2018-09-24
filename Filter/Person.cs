using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveJson
{

    class Person
    {
        public Person(int id, string name, DateTime birthday, Gender gender)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Gender = gender;
        }

        public Person()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
    }
}
