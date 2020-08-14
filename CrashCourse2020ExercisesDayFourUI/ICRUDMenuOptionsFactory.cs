using CrashCourse2020ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2020ExercisesDayFourUI
{
    public interface ICRUDMenuOptionsFactory
    {
        IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option);

        IConsoleOutputBuilder GetMenu();
    }
}