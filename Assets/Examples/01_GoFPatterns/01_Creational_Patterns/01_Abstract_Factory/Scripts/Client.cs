using System;
using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Factories;
using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products;
using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.UI;
using UnityEngine;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private ChangeTypeText _changeTypeText;
        [SerializeField] private ChangeProductText _changeProductText;
        [SerializeField] private ChangeTypeButton _changeTypeButton;
        [SerializeField] private SpawnButton _spawnButton;
        [SerializeField] private AttackButton _attackButton;

        private event Action FactoryTypeChanged;
        private EnemiesFactory _currentFactory;
        private EnemyProduct _currentProduct;
        
        private void Awake()
        {
            _changeTypeButton.OnClick += ChangeFactoryType;
            _spawnButton.OnClick += SpawnProduct;
            _attackButton.OnClick += CurrentProductAttack;
            FactoryTypeChanged += ChangeFactoryTypeText;
        }

        private void Start()
        {
            ChangeFactoryType(new KnightFactory());
            _changeProductText.ChangeText("null");
        }

        private void ChangeFactoryType(EnemiesFactory factory)
        {
            _currentFactory = factory;
            FactoryTypeChanged?.Invoke();
        }

        private void SpawnProduct()
        {
            _currentProduct = _currentFactory.CreateProduct();
            _changeProductText.ChangeText(_currentProduct.GetProductName());
        }

        private void CurrentProductAttack()
        {
            _currentProduct?.Attack();
        }

        private void ChangeFactoryTypeText()
        {
            _changeTypeText.ChangeText(_currentFactory.GetFactoryName());
        }

        private void OnDisable()
        {
            _changeTypeButton.OnClick -= ChangeFactoryType;
            _spawnButton.OnClick -= SpawnProduct;
            _attackButton.OnClick -= CurrentProductAttack;
            FactoryTypeChanged -= ChangeFactoryTypeText;
        }
    }
}