using UnityEngine;

namespace Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Services
{
    public abstract class AbstractCountService
    {
        protected int CurrentCount { get; set; } = 0;
        public abstract int IncreaseCount();
    }
}
