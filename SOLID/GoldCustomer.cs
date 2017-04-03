namespace SOLID
{
	public class GoldCustomer : Customer
	{
		public override double GetDiscount(double basketCost)
		{
			return base.GetDiscount(basketCost) - 20;
		}
	}
}
