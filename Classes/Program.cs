namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2004;
            Car momCar = new Car();
            momCar.Make = "Volvo";
            momCar.Model = "S-60";
            momCar.Year = 2013;
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
