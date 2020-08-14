using System;
using CrashCourse2020ExercisesDayFourUI.Default;
using CrashCourse2020ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2020ExercisesDayFourUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new DefaultPrinter();
            var areaFactory = new AreaFactory();
            Console.WriteLine(printer.ShowGreetingAndMainMenu());
            printer.ReadAreaFromString(out var area);
            var factory = areaFactory.GetOptionsFactory(area);
            while (factory != null && !(factory is ExitCRUDMenuOptionsFactory))
            {
                Console.WriteLine(factory.GetMenu().GetConsoleOutputAsString());
                printer.ReadCRUDOptionsFromString(out var option);
                var optionFactory = factory.GetOutputBuilder(option);
                while (optionFactory != null)
                {
                    Console.WriteLine(optionFactory.GetConsoleOutputAsString());
                    
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.WriteLine(factory.GetMenu().GetConsoleOutputAsString());
                    //New Selection Inner Menu
                    printer.ReadCRUDOptionsFromString(out option);
                    optionFactory = factory.GetOutputBuilder(option);

                }
                //Next selection Outer Menu   
                Console.WriteLine(printer.ShowGreetingAndMainMenu());
                printer.ReadAreaFromString(out area);
                factory = areaFactory.GetOptionsFactory(area);

            }

            Console.WriteLine(factory == null
                ? "System Crash or Menu not implemented! Sorry"
                : factory.GetOutputBuilder(CRUDMenuOptions.Unknown).GetConsoleOutputAsString());
        }
    }
}
