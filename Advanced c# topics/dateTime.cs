//simple data time
            DateTime myBDay = new DateTime(1998, 11, 05);
            Console.WriteLine($"My b day is {myBDay}");

            //Write today on screen
            Console.WriteLine(DateTime.Today);
            //Write current time on screen
            Console.WriteLine(DateTime.Now);

            //Day for tomorrow
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");

            //Which day of the week we have today 
            Console.WriteLine(DateTime.Today.DayOfWeek);

            //Firs Day of Year
            Console.WriteLine($"First day of the year {GetFirstDayOfTYear(1998)}");

            //How many days date have
            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in Feb 2000: {days}");

            //Current time 
            DateTime minute = DateTime.Now;
            Console.WriteLine($"Minute {minute.Minute}");

            Console.WriteLine($"It's {DateTime.Now.Hour} o'clock {DateTime.Now.Minute} minutes and {DateTime.Now.Second} seconds");

            //How much time is between now and time that we enter
            Console.WriteLine("Eneter a date in this format yyyy-mm-dd");
            string input = Console.ReadLine();
            DateTime now = DateTime.Now;
            DateTime dateTime;

            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPasses = now.Subtract(dateTime);
                Console.WriteLine($"Days passes since {daysPasses.Days}");
            }
            else
                Console.WriteLine("Wrong Input");

            //Days passes since Bday
            Console.WriteLine("Eneter a date of yor Bday in this format yyyy-mm-dd");
            string Bday = Console.ReadLine();
            DateTime BdayNumber;

            if (DateTime.TryParse(Bday, out BdayNumber))
            {
                TimeSpan daysPasses = now.Subtract(BdayNumber);
                Console.WriteLine($"{daysPasses.Days} days passes since your Bday");
            }
            else
                Console.WriteLine("Wrong Input");

            Console.ReadKey();
        }

        #region
        //Method to get day for tomorrow
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        #endregion

        #region
        //Get first day of the year
        static DateTime GetFirstDayOfTYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
        #endregion
