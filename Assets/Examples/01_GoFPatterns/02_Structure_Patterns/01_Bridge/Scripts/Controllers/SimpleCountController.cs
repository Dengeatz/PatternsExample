namespace Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Controllers
{
    public class SimpleCountController : AbstractCountController
    {
        public override void IncreaseCount()
        {
            OnCountChanged?.Invoke(CountService.IncreaseCount());
        }
    }
}