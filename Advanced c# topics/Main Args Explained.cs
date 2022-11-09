 //checking lengh of array
            Console.WriteLine(args.Length);

            Console.WriteLine("Enter help for more info");
            if (args[0] == "help")
            {
                Console.WriteLine("Instruction:");
                Console.WriteLine("use one of the following comands followed by 2 numbers");
                Console.WriteLine("'add' to add 2 numbers");
                Console.WriteLine("'sub' to substract 2 numbers");

                Console.ReadKey();
                return;
            }

            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments!");
                //pause
                Console.ReadKey();
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (isNum1Parsed || isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments!");
                Console.ReadKey();
                return;
            }

            float result;
            switch (args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum is {result}");
                    break;

                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The substract is {result}");
                    break;

                default:
                    Console.WriteLine("Invalid arguments!");
                    break;
            }

            Console.ReadKey();
