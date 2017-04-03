namespace SOLID
{
	public class SilverCustomer : Customer
	{
		public override double GetDiscount(double basketCost)
		{
			return base.GetDiscount(basketCost) - 5;
		}
	}
}
