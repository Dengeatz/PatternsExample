using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Factories
{
    public class KnightFactory : EnemiesFactory
    {
        public override EnemyProduct CreateProduct()
        {
            return new KnightProduct();
        }

        public override string GetFactoryName()
        {
            return "Knight factory";
        }
    }
}