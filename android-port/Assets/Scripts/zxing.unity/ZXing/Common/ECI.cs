namespace ZXing.Common
{
	public abstract class ECI
	{
		public virtual int Value { get; private set; }

		internal ECI(int val)
		{
		}
	}
}
