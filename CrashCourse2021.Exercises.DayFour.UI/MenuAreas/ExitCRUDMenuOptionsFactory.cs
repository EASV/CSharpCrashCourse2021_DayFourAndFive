using CrashCourse2021.Exercises.DayFour.UI.MenuAreas.Builders;

namespace CrashCourse2021.Exercises.DayFour.UI.MenuAreas
{
    public class ExitCRUDMenuOptionsFactory: ICRUDMenuOptionsFactory
    {
        public IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option)
        {
            return new ExitBuilder();
        }

        public IConsoleOutputBuilder GetMenu()
        {
            throw new System.NotImplementedException();
        }
    }
}