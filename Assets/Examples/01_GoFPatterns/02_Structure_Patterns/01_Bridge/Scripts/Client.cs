using System;
using Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Controllers;
using Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Examples._01_GoFPatterns._02_Structure_Patterns._01_Bridge.Scripts
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private Button s_countButton;
        [SerializeField] private Button s_changeServiceButton;
        [SerializeField] private TMP_Text s_countText;
        [SerializeField] private TMP_Text s_changeServiceText;
        private int _index = 0;
        private AbstractCountController _countController;

        private void Awake()
        {
            _countController = new SimpleCountController();
        }

        private void OnEnable()
        {
            s_countButton.onClick.AddListener(IncreaseCount);
            s_changeServiceButton.onClick.AddListener(ChangeServiceOnClick);
            _countController.OnCountChanged += CountChanged;
            _countController.OnServiceChanged += ServiceChanged;
            
            // Init Settings
            _countController.SetService(new SimpleCountService());
        }

        private void OnDisable()
        {
            s_countButton.onClick.RemoveListener(IncreaseCount);
            s_changeServiceButton.onClick.RemoveListener(ChangeServiceOnClick);
            _countController.OnCountChanged -= CountChanged;
            _countController.OnServiceChanged -= ServiceChanged;
        }

        private void CountChanged(int newCount)
        {
            s_countText.text = $"Current Count: {newCount}";
        }

        private void ServiceChanged(AbstractCountService newService)
        {
            s_changeServiceText.text = $"Current Service: {newService.GetType().Name}";
        }
        
        private void IncreaseCount()
        {
            _countController.IncreaseCount();
        }

        private void ChangeServiceOnClick()
        {
            if (_index == 0)
            {
                _index++;
                ChangeService(new SimpleCountService());
            }
            else if (_index == 1)
            {
                _index--;
                ChangeService(new DoubleIncreaseCountService());
            }
        }

        private void ChangeService(AbstractCountService service)
        {
            _countController.SetService(service);
        }
    }
}