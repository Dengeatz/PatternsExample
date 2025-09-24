namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products
{
    public class ArcherProduct : EnemyProduct
    {
        public override void Attack()
        {
            UnityEngine.Debug.Log("Archer Attacking");
        }

        public override string GetProductName()
        {
            return "Archer";
        }
    }
}