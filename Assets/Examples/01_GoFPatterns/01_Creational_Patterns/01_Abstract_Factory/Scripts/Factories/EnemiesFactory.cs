using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Factories
{
    public abstract class EnemiesFactory
    {
        public abstract EnemyProduct CreateProduct();
        public abstract string GetFactoryName();
    }
}