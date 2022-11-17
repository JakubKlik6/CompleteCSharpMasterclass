//defining delegate 
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Marek", Age = 16 };
            Person p2 = new Person() { Name = "Jakub", Age = 26 };
            Person p3 = new Person() { Name = "Jasiu", Age = 24 };
            Person p4 = new Person() { Name = "Ola", Age = 99 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            //Lambda statement
            string searchKeyWord = "A";
            DisplayPeople("Age greater than 20 with search key word " + searchKeyWord, people, p =>
            {
                if (p.Name.Contains(searchKeyWord) && p.Age > 20)
                {
                    return true;
                }
                else return false;
            });

            //Lambda expression
            DisplayPeople("\nExacly 24 years old: ", people, p => p.Age == 24);
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
