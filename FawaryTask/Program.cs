using FawaryTask.Classes;

namespace FawaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Create a Gas Car:");
            Car myCar = CarFactory.CreateCar("gas");
            myCar.Start();
            myCar.Accelerate(); // السرعة هتبقى 20
            myCar.Brake();      // السرعة هتبقى 0
            myCar.Stop();

            
            Console.WriteLine("Create a Hybrid Car:");
            myCar = CarFactory.CreateCar("hybrid");
            myCar.Start();

            
            myCar.Accelerate(); // 20 
            myCar.Accelerate(); // 40 
            myCar.Accelerate(); // 60 Gas

            Console.WriteLine("Replacing Engine while Car is Moving:");
            Console.WriteLine($"Current Speed after swap: {myCar.CurrentSpeed}");

            
            myCar.ReplaceEngine(new ElectronicEngine()); //0  لاني عملت اوبجيكت جديد السرعه الديفولت بتاعه 0

            myCar.Accelerate(); //20

            
            Console.WriteLine("Trying to stop while moving:");
            myCar.Stop();
        }
    }
}
