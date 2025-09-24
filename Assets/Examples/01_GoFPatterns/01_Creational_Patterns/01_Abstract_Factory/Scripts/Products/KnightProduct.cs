namespace Examples._01_GoFPatterns._01_Creational_Patterns._01_Abstract_Factory.Scripts.Products
{
    public class KnightProduct : EnemyProduct
    {
        public override void Attack()
        {
            UnityEngine.Debug.Log("Knight attacking!");
        }
        
        public override string GetProductName()
        {
            return "Knight";
        }
    }
}