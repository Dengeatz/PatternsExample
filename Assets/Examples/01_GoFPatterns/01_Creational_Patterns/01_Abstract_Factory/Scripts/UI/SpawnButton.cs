using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.UI
{
    public class SpawnButton : MonoBehaviour, IPointerClickHandler
    {
        public event Action OnClick;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClick?.Invoke();
        }
    }
}
