int? num1 = null;

            double? num2 = new Double?();
            double? num3 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine($"Our nullable are: {num1}, {num2}, {num3}");
            Console.WriteLine($"Nullable value is: {boolVal}");

            //example
            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is not male");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            //example 2
            double? numX = 13.1;
            double? numy = 7.5;
            double num;

            if (numX == null)
            {
                num = 0.0;
            }
            else
            {
                num = (double)numX;
            }

            Console.WriteLine(num);

            //Shortcut
            num = numX ?? 13.1;
            Console.WriteLine(num);
