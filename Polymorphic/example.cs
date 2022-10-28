internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi("black",200,"A6"),
                new Bmw("white", 250,"M2")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }
        }
    }

    internal class Car
    {
        public string Color { get; set; }
        public int HP { get; set; }

        public Car(string Color, int HP)
        {
            this.Color = Color;
            this.HP = HP;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Car power: {HP}, car color {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }

    internal class Bmw : Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }
        public Bmw(string Color, int HP, string Model) : base(Color, HP)
        {
            this.Model = Model;
            this.Brand = "Bmw";
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Car power: {HP}, car color: {Color}, car brand: {Brand}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} was repaired");
        }
    }

    internal class Audi : Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }
        public Audi(string Color, int HP, string Model) : base(Color, HP)
        {
            this.Model = Model;
            this.Brand = "Audi";
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Car power: {HP}, car color: {Color}, car brand: {Brand}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} was repaired");
        }
    }
