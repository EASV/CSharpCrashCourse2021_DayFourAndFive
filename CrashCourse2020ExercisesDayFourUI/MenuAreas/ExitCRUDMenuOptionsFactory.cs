using CrashCourse2020ExercisesDayFourUI.MenuAreas.Builders;

namespace CrashCourse2020ExercisesDayFourUI.MenuAreas
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