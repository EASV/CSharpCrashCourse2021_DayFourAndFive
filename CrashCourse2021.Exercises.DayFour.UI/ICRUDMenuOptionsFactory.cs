using CrashCourse2021.Exercises.DayFour.UI.MenuAreas;

namespace CrashCourse2021.Exercises.DayFour.UI
{
    public interface ICRUDMenuOptionsFactory
    {
        IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option);

        IConsoleOutputBuilder GetMenu();
    }
}