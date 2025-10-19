using System;
using Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Services;

namespace Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Controllers
{
    public abstract class AbstractCountController
    {
        protected AbstractCountService CountService;
        public Action<AbstractCountService> OnServiceChanged;
        public Action<int> OnCountChanged;

        public virtual void SetService(AbstractCountService service)
        {
            CountService = service;
            OnServiceChanged?.Invoke(service);
        }
        
        public abstract void IncreaseCount();
    }
}