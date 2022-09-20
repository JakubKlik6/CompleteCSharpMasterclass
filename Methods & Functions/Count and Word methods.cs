tatic void Main(string[] args)
        {
            Console.Write("Uppercase and lowercase: ");
            WordCopies("Jasiu");

            Console.WriteLine("");

            Count("Jasiu");

            Console.Read();
        }

        public static void WordCopies(string word)
        {
            Console.WriteLine(word.ToLower() + word.ToUpper());
        }

        public static void Count(string word)
        {
            Console.WriteLine("The amount of characters is: {0}", word.Length);
        }
