namespace SOLID
{
	public class TemporaryBuddy : IDiscount
	{
		public double GetDiscount(double basketCost)
		{
			return basketCost - 1;
		}
	}
}
