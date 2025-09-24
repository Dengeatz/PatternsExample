namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products
{
    public abstract class EnemyProduct
    {
        public abstract void Attack();

        public virtual string GetProductName()
        {
            return "Not selected";
        }
    }
}