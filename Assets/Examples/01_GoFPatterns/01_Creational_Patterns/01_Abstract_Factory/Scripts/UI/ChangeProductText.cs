using TMPro;
using UnityEngine;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.UI
{
    public class ChangeProductText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
    
        public void ChangeText(string currentProduct)
        {
            _text.text = $"Current spawned product: {currentProduct}";
        }
    }
}