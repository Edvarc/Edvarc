using System;

namespace ConsoleApp1
{
    public /* to kaut kāpēc pierakstījām klāt */ class Person
    { public Person(string name)
        { Name = name; }
        public string Name { get;  }

        // īpašumi jeb properties ir tās divas metodes - get un set
        private int _age; 
        public int Age        { 
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }

                }

             

        public double Money { get; set; }

        public bool IsMale { get; set; }

        public char Initial { get; set; }

        public string GetGreeting() // šī kaut kāda īpašā metode
        {
            string greeting = "Hello, my name is " + Name + "and I am " + Age;

            return greeting;
        }
    }
}
