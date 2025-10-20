using System;
using Examples._01_GoFPatterns._03_Behavior_Patterns._01_Strategy.Scripts.Strategies;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Examples._01_GoFPatterns._03_Behavior_Patterns._01_Strategy.Scripts
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private Button s_changeStrategyBtn;
        [SerializeField] private Button s_earnMoneyBtn;
        [SerializeField] private TMP_Text s_earnMoneyText;
        [SerializeField] private TMP_Text s_currentStrategyText;

        private IEarnable _currentStrategy;
        private int _currentMoney = 0;
        
        private void OnEnable()
        {
            s_changeStrategyBtn.onClick.AddListener(ChangeStrategy);
            s_earnMoneyBtn.onClick.AddListener(EarnMoney);
            ChangeStrategy(new DefaultEarn());
        }

        private void ChangeStrategy()
        {
            if (_currentStrategy.GetType() == typeof(DefaultEarn))
            {
                _currentStrategy = new DoubleEarn();
                OnChangeStrategy(_currentStrategy);
            }
            else
            {
                _currentStrategy = new DefaultEarn();
                OnChangeStrategy(_currentStrategy);
            }
        }
        
        private void ChangeStrategy(IEarnable earnable)
        {
            _currentStrategy = earnable;
            OnChangeStrategy(_currentStrategy);
        }

        private void EarnMoney()
        {
            _currentStrategy.Earn(ref _currentMoney);
            OnEarnMoney();
        }

        private void OnChangeStrategy(IEarnable newStrategy)
        {
            s_currentStrategyText.text = $"Current Strategy: {newStrategy.GetType().Name}";
        }

        private void OnEarnMoney()
        {
            s_earnMoneyText.text = $"Current Money: {_currentMoney}";
        }
        
        private void OnDisable()
        {
            s_changeStrategyBtn.onClick.RemoveListener(ChangeStrategy);
            s_earnMoneyBtn.onClick.RemoveListener(EarnMoney);
        }
    }
}