static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Jakub", "Jasiu", "Werka", "Ola" };

            //print names before the remove all method
            Console.WriteLine("----- before -----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling remove all method with filter 
            names.RemoveAll(FilterName);

            //print names after the remove all method
            Console.WriteLine("----- after -----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        static bool FilterName(string name)
        {
            //return name that contain i letter 
            return name.Contains("i");
        }
