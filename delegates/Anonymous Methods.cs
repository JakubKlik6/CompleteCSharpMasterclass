//defining delegate 
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Marek", Age = 16 };
            Person p2 = new Person() { Name = "Jakub", Age = 26 };
            Person p3 = new Person() { Name = "Jasiu", Age = 24 };
            Person p4 = new Person() { Name = "Ola", Age = 99 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsAdult);

            //anonymus method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Kids", people, filter);

            //anonymus method as a parameter
            DisplayPeople("All: ", people, delegate (Person p) { return true; });


            Console.ReadKey();
        }

        static public void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                //check if the person passes filter
                if (filter(p))
                {
                    //print name and age
                    Console.WriteLine($"{p.Name},{p.Age} years old");
                }
            }
        }

        static public bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static public bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static public bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
