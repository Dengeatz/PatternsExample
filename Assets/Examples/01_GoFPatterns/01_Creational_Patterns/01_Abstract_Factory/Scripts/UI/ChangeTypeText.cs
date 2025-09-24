using TMPro;
using UnityEngine;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.UI
{
    public class ChangeTypeText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
    
        public void ChangeText(string currentType)
        {
            _text.text = $"Current selected type: {currentType}";
        }
    }
}
