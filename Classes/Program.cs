namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //option 1
            var myCar1 = new Car("Hyundai", "Kona", 2022);

            //option 2
            var myCar2 = new Car();
            myCar2.Make = "Honda";
            myCar2.Model = "Civic";
            myCar2.Year = 2021;

            //option 3
            var myCar3 = new Car()
            {
                Make = "Chevy",
                Model = "Nova",
                Year = 1974
            };

            var carList = new List<Car>() { myCar1, myCar2, myCar3 };

            foreach(var ride in carList)
            {
                Console.WriteLine($"{ride.Make} {ride.Model} {ride.Year}");
            }
        }
    }
}
