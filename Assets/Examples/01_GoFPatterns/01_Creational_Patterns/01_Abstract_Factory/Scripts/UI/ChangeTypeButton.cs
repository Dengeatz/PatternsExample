using System;
using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Factories;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.UI
{
    public class ChangeTypeButton : MonoBehaviour, IPointerClickHandler
    {
        private float i = 0;
        public event Action<EnemiesFactory> OnClick;
    
        public void OnPointerClick(PointerEventData eventData)
        {
            i++;
            i = UnityEngine.Mathf.PingPong(i, 1);
            // Смотрим, если текущая фабрика это мечники, то меняем на следующую, т.е. на лучников и также в обратном порядке.
            switch (i)
            {
                case 0:
                    OnClick?.Invoke(new KnightFactory());  
                    break;
                case 1:
                    OnClick?.Invoke(new ArcherFactory());  
                    break;
            }
        }
    }
}
