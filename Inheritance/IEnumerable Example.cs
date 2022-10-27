static void Main(string[] args)
        {
            //creating a generic IEnumerable variable that takes any collection of any type int
            //we will use this variable to store the collections that will get returned by the GetColletion() method
            IEnumerable<int> unkownCollection;
            unkownCollection = GetCollection(1);

            Console.WriteLine("This was a list <int>");
            //foreach number in the collection we got back from GetColletion(1)
            foreach (int num  in unkownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unkownCollection = GetCollection(2);
            Console.WriteLine("This was a queue <int>");
            //foreach number in the collection we got back from GetColletion(1)
            foreach (int num in unkownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unkownCollection = GetCollection(5);
            Console.WriteLine("This was a array of int");
            //foreach number in the collection we got back from GetColletion(1)
            foreach (int num in unkownCollection)
            {
                Console.Write(num + " ");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {
            //list of numbers
            List<int> numberList = new List<int>() { 1,2,3,4,5};

            Queue<int> numberQueue = new Queue<int>();
            //add values to queue
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (option == 1)
            {
                return numberList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else return new int[] { 11, 12, 13, 14, 15 };
        }
