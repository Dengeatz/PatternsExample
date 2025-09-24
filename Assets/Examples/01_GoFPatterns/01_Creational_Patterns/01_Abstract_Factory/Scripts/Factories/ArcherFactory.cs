using Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products;

namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Factories
{
    public class ArcherFactory : EnemiesFactory
    {
        public override EnemyProduct CreateProduct()
        {
            return new ArcherProduct();
        }

        public override string GetFactoryName()
        {
            return "Archer factory";
        }
    }
}