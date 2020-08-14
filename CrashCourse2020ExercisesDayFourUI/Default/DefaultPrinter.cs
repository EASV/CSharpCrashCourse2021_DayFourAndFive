using System;
using CrashCourse2020ExercisesDayFourUI.Constants;
using CrashCourse2020ExercisesDayFourUI.MenuAreas;
using CrashCourse2020ExercisesDayFourUI.Utils;

namespace CrashCourse2020ExercisesDayFourUI.Default
{
    public class DefaultPrinter
    {
        private readonly IMenuUtils _utils;
        
        public DefaultPrinter()
        {
            _utils = new MenuUtils();
         }
        
        public string ShowGreetingAndMainMenu()
        {
            return $"{WelcomeGreeting()}{ShowMainMenu()}{MenuConstants.Line}";
        }

        private string WelcomeGreeting()
        {
            return MenuConstants.WelcomeGreeting;
        }

        private string ShowMainMenu()
        {
            var mainMenu = MenuConstants.MainMenu;
            var areaArray = Enum.GetValues(typeof(Areas));
            foreach(Areas area in areaArray )
            {
                var addLine = $"{(int)area}: {Enum.GetName(typeof(Areas), area)} \n";
                mainMenu = string.Concat(mainMenu, addLine);
            }
            return mainMenu;
        }
        
        private string PrintBadMenuSelection()
        {
            return MenuConstants.StringIsNotANumber;
        }

        public void ReadAreaFromString(out Areas area)
        {
            _utils.ReadIntegerFromString("", out var selection);
            while (!Enum.IsDefined(typeof(Areas), selection))
            {   Console.Clear();
                Console.WriteLine(PrintBadMenuSelection());
                Console.WriteLine(ShowMainMenu());
                _utils.ReadIntegerFromString("", out selection);
            }
            area = (Areas)selection;
        }
        
        public void ReadCRUDOptionsFromString(out CRUDMenuOptions crudOption)
        {
            _utils.ReadIntegerFromString("", out var selection);
            while (!Enum.IsDefined(typeof(CRUDMenuOptions), selection))
            {   Console.Clear();
                Console.WriteLine(PrintBadMenuSelection());
                _utils.ReadIntegerFromString("", out selection);
            }
            crudOption = (CRUDMenuOptions)selection;
        }
    }
}