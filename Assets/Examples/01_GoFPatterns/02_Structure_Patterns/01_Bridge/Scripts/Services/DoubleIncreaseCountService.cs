namespace Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Services
{
    public class DoubleIncreaseCountService : AbstractCountService
    {
        public override int IncreaseCount()
        {
            return CurrentCount += 2;
        }
    }
}