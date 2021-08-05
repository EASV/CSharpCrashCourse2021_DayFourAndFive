using CrashCourse2021ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2021ExercisesDayFourUI
{
    public interface ICRUDMenuOptionsFactory
    {
        IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option);

        IConsoleOutputBuilder GetMenu();
    }
}