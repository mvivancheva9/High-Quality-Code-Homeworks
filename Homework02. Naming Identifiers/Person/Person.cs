namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public void MakePerson(int age)
        {
            var person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "John";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Jasmine";
                person.Gender = Gender.Female;
            }
        }
    }
}
