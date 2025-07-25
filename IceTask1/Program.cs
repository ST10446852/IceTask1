namespace IceTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = new Object(1, "Object 1");
            Object obj2 = new Object(2, "Object 2");

            
            Console.WriteLine($"Using {obj1.Name} and {obj2.Name}");

            
            obj1 = null;
            obj2 = null;

            
            Console.WriteLine("Forcing garbage collection...");

            GC.Collect();

            GC.WaitForPendingFinalizers();

            Console.WriteLine("Garbage collection complete.");

            Console.ReadLine();
        }
    }
}
